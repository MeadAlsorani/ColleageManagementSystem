import { TranslateService } from '@ngx-translate/core';
import {
  HttpInterceptor,
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpHeaders,
} from '@angular/common/http';
import { Injectable } from '@angular/core';
import { catchError, Observable, throwError } from 'rxjs';
import { environment } from 'src/environments/environment';

@Injectable()
export class RequestHandlerInterceptor implements HttpInterceptor {
  constructor(private translationService: TranslateService) {}
  intercept(
    req: HttpRequest<any>,
    next: HttpHandler
  ): Observable<HttpEvent<any>> {
    let headers = new HttpHeaders();
    headers = headers.append('Authorization', `Bearer ${environment.token}`);
    if (!req.url.includes('i18n')) {
      headers = headers.append(
        'Accept-Language',
        this.translationService.currentLang
      );
    }
    const authReq = req.clone({ headers: headers });

    return next.handle(authReq).pipe(
      catchError((err) => {
        console.log(err);
        // console.log(err.);

        return throwError(() => new Error(err));
      })
    );
  }
}
