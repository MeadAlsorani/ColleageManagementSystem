import { EditSessionYearComponent } from './edit-session-year/edit-session-year.component';
import { AddSessionYearComponent } from './add-session-year/add-session-year.component';
import { SessionYearRoutes } from './session-year.routing';
import { SharedModule } from 'src/app/shared/sharedModule.module';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SessionYearComponent } from './session-year.component';

@NgModule({
  imports: [CommonModule, SharedModule, SessionYearRoutes],
  declarations: [
    SessionYearComponent,
    AddSessionYearComponent,
    EditSessionYearComponent,
  ],
})
export class SessionYearModule {}
