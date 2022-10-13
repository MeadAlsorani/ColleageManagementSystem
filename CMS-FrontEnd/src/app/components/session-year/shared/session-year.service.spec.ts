/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { SessionYearService } from './session-year.service';

describe('Service: SessionYear', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [SessionYearService]
    });
  });

  it('should ...', inject([SessionYearService], (service: SessionYearService) => {
    expect(service).toBeTruthy();
  }));
});
