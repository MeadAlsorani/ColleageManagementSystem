import { CommonService } from './../services/common.service';
import { Component, Injector, OnDestroy } from '@angular/core';
import { FormBuilder } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { TranslateService } from '@ngx-translate/core';
import { Subscription } from 'rxjs';
import { PaginationPayload } from '../interfaces/Request';
import { MatSnackBar } from '@angular/material/snack-bar';

@Component({
  selector: 'base-component',
  template: '',
  styles: [],
})
export class BaseComponent implements OnDestroy {
  pagination: PaginationPayload = {
    Ascending: false,
    PageIndex: 0,
    PageSize: 20,
    SortBy: 'Id',
  };
  formBuilder: FormBuilder = new FormBuilder();
  subscriptions: Subscription[] = [];
  protected route: ActivatedRoute;
  protected router: Router;
  protected translateService: TranslateService;
  protected commonService: CommonService;
  protected snackBar: MatSnackBar;
  constructor(injector: Injector) {
    this.snackBar = injector.get(MatSnackBar);
    this.route = injector.get(ActivatedRoute);
    this.router = injector.get(Router);
    this.translateService = injector.get(TranslateService);
    this.commonService = injector.get(CommonService);
  }
  ngOnDestroy(): void {
    this.subscriptions.forEach((sub) => sub.unsubscribe());
  }
  openNotification() {
    this.snackBar.open(
      this.translateService.instant('Operation succeeded'),
      undefined,
      {
        horizontalPosition: 'center',
        verticalPosition: 'top',
        duration: 4000,
        panelClass: 'success-panel',
      }
    );
  }
}
