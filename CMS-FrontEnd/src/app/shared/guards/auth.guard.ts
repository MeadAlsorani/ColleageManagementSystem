import { environment } from './../../../environments/environment';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import {
  ActivatedRouteSnapshot,
  CanActivate,
  Router,
  RouterStateSnapshot,
  UrlTree,
} from '@angular/router';
import { catchError, Observable, tap, throwError } from 'rxjs';
import { JwtHelperService } from '@auth0/angular-jwt';
import { User } from '../interfaces/User';

@Injectable({
  providedIn: 'root',
})
export class AuthGuard implements CanActivate {
  constructor(
    private router: Router,
    private jwtService: JwtHelperService,
    private http: HttpClient
  ) {}
  async canActivate(
    route: ActivatedRouteSnapshot,
    state: RouterStateSnapshot
  ): Promise<any> {
    const token = localStorage.getItem('token');
    if (token != null && !this.jwtService.isTokenExpired(token)) {
      return true;
    }

    let isRefreshToken: boolean = false;
    try {
      isRefreshToken = await this.TryRefreshToken(token!);
    } catch {}
    if (!isRefreshToken) this.router.navigate(['/auth/login']);
    return token != null ? true : false;
  }

  private async TryRefreshToken(token: string): Promise<boolean> {
    const refreshToken = localStorage.getItem('refresh-token');
    if (!token || !refreshToken) {
      return false;
    }
    // return await new Promise<boolean>((resolve, reject) => {});
    let isRefreshToken: boolean;
    let refreshRes: User = {
      email: '',
      fullName: '',
      id: '',
      role: '',
      token: '',
      userName: '',
      refreshToken: '',
    };
    console.log('refresh from guard');
    refreshRes = await new Promise<User>((resolve, reject) => {
      this.http
        .post(`${environment.apiUrl}Authentication/RefreshToken`, {
          Token: token,
          RefreshToken: refreshToken,
        })
        .pipe(
          tap((response: any) => {
            console.log('refresh from guard', response);
            isRefreshToken = true;
            localStorage.setItem('token', response.token);
            localStorage.setItem('refresh-token', response.refreshToken);
            resolve(response);
          }),
          catchError(() => {
            isRefreshToken = false;
            reject();
            return throwError(() => new Error());
          })
        )
        .subscribe();
    });
    isRefreshToken = true;
    return isRefreshToken;
  }
}
