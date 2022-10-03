import { Component, Injector, OnDestroy } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Subscription } from 'rxjs';
import { PaginationPayload } from '../interfaces/Request';

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
  subscriptions: Subscription[] = [];
  protected route: ActivatedRoute;
  protected router: Router;
  constructor(injector: Injector) {
    this.route = injector.get(ActivatedRoute);
    this.router = injector.get(Router);
  }
  ngOnDestroy(): void {
    this.subscriptions.forEach((sub) => sub.unsubscribe());
  }
}
