import { AuthService } from './../../components/Authentication/auth.service';
import { TranslateService } from '@ngx-translate/core';
import {
  HttpInterceptor,
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpHeaders,
  HttpClient,
} from '@angular/common/http';
import { Injectable } from '@angular/core';
import {
  catchError,
  Observable,
  retry,
  switchMap,
  tap,
  throwError,
} from 'rxjs';
import { environment } from 'src/environments/environment';
import { RetryConfig } from 'rxjs/internal/operators/retry';

@Injectable()
export class RequestHandlerInterceptor implements HttpInterceptor {
  refreshTokenInProgress = false;

  constructor(
    private translationService: TranslateService,
    private authService: AuthService
  ) {}
  intercept(
    req: HttpRequest<any>,
    next: HttpHandler
  ): Observable<HttpEvent<any>> {
    const authReq = this.addHeaders(req);
    const config: RetryConfig = {
      delay: 500,
      count: 2,
    };
    return next.handle(authReq).pipe(
      catchError((err) => {
        console.log(err);

        // return throwError(() => new Error(err));
        return this.handleResponseError(err, req, next);
      }),
      retry(config)
    );
  }

  refreshToken(): Observable<any> {
    console.log('refresh from interceptor');

    const refreshToken = localStorage.getItem('refresh-token')!;
    const token = localStorage.getItem('token')!;
    if (this.refreshTokenInProgress) {
      return new Observable((observer) => {
        this.authService
          .refreshToken(token, refreshToken)
          .pipe(
            tap((response: any) => {
              console.log('refresh from interceptor', response);
              localStorage.setItem('token', response.token);
              localStorage.setItem(
                'refresh-token',
                response.refreshToken as string
              );
              observer.next();
              observer.complete();
            })
          )
          .subscribe();
      });
    } else {
      this.refreshTokenInProgress = true;

      return this.authService.refreshToken(token, refreshToken).pipe(
        tap((response: any) => {
          localStorage.setItem('token', response.token);
          localStorage.setItem(
            'refresh-token',
            response.refreshToken as string
          );
          this.refreshTokenInProgress = false;
        }),
        catchError(() => {
          this.refreshTokenInProgress = false;
          this.authService.logOut();
          return throwError(() => new Error());
        })
      );
    }
  }

  addHeaders(req: HttpRequest<any>) {
    let headers = new HttpHeaders();
    const token = localStorage.getItem('token');
    headers = headers.append('Authorization', `Bearer ${token}`);
    if (!req.url.includes('i18n')) {
      headers = headers.append(
        'Accept-Language',
        this.translationService.currentLang
      );
    }
    const request = req.clone({ headers: headers });
    return request;
  }

  handleResponseError(
    error: any,
    request?: HttpRequest<any>,
    next?: HttpHandler
  ): Observable<any> {
    // Business error
    if (error.status === 400) {
      // Show message
    }

    // Invalid token error
    else if (error.status === 401) {
      return this.refreshToken().pipe(
        switchMap(() => {
          request = this.addHeaders(request!);
          return next!.handle(request);
        }),
        catchError((e: any) => {
          if (e.status !== 401) {
            return this.handleResponseError(e);
          } else {
            this.authService.logOut();
            return new Observable();
          }
        })
      );
    }

    // Access denied error
    else if (error.status === 403) {
      // Show message
      // Logout
      this.authService.logOut();
    }

    // Server error
    else if (error.status === 500) {
      // Show message
    }

    // Maintenance error
    else if (error.status === 503) {
      // Show message
      // Redirect to the maintenance page
    }

    return throwError(() => new Error(error));
  }
}
