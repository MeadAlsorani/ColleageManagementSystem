/* tslint:disable:no-unused-variable */
import { async, ComponentFixture, TestBed } from '@angular/core/testing';
import { By } from '@angular/platform-browser';
import { DebugElement } from '@angular/core';

import { EditSessionYearComponent } from './edit-session-year.component';

describe('EditSessionYearComponent', () => {
  let component: EditSessionYearComponent;
  let fixture: ComponentFixture<EditSessionYearComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EditSessionYearComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EditSessionYearComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
