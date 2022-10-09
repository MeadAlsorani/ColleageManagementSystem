import { Router } from '@angular/router';
import { environment } from './../../../environments/environment';
import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';
import { User } from 'src/app/shared/interfaces/User';

@Injectable({
  providedIn: 'root',
})
export class AuthService {
  _userData = new BehaviorSubject<User>({
    email: '',
    fullName: '',
    id: '',
    role: '',
    token: '',
    userName: '',
  });
  set userData(value: User) {
    this._userData.next(value);
    localStorage.setItem('token', value.token);
    localStorage.setItem('refresh-token', value.refreshToken as string);
    localStorage.setItem('userData', JSON.stringify(value));
  }
  get userData() {
    return this._userData.value;
  }
  constructor(private http: HttpClient, private router: Router) {
    const data = localStorage.getItem('userData');
    if (data != null && data != '') {
      this.userData = JSON.parse(data);
    }
  }
  login(username: string, password: string) {
    return this.http.get(
      `${environment.apiUrl}Authentication?username=${username}&password=${password}`
    );
  }
  refreshToken(token: string, refreshToken: string) {
    return this.http.post(`${environment.apiUrl}Authentication/RefreshToken`, {
      Token: token,
      RefreshToken: refreshToken,
    });
  }
  logOut() {
    localStorage.removeItem('token');
    localStorage.removeItem('refresh-token');
    this.router.navigate(['/auth/login']);
  }
}
