/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { SalaryTemplateService } from './salary-template.service';

describe('Service: SalaryTemplate', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [SalaryTemplateService]
    });
  });

  it('should ...', inject([SalaryTemplateService], (service: SalaryTemplateService) => {
    expect(service).toBeTruthy();
  }));
});
