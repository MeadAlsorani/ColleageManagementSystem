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
    localStorage.setItem('userData', JSON.stringify(value));
  }
  get userData() {
    return this._userData.value;
  }
  constructor(private http: HttpClient) {
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
}
