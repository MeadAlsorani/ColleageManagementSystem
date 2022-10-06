import { Router } from '@angular/router';
import { tap } from 'rxjs';
import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';
import { AuthService } from '../auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.less'],
})
export class LoginComponent implements OnInit {
  form: FormGroup = new FormGroup({
    username: new FormControl(''),
    password: new FormControl(''),
  });
  constructor(private authService: AuthService, private router: Router) {}

  ngOnInit() {}
  submit() {
    if (this.form.valid) {
      const formValue = this.form.value;
      this.authService
        .login(formValue.username, formValue.password)
        .pipe(
          tap((response: any) => {
            this.authService.userData = response;
            this.router.navigate(['/']);
          })
        )
        .subscribe();
    }
  }
}
