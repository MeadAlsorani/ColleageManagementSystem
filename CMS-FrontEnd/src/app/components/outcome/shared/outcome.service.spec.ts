/* tslint:disable:no-unused-variable */

import { TestBed, async, inject } from '@angular/core/testing';
import { OutcomeService } from './outcome.service';

describe('Service: Outcome', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [OutcomeService]
    });
  });

  it('should ...', inject([OutcomeService], (service: OutcomeService) => {
    expect(service).toBeTruthy();
  }));
});
