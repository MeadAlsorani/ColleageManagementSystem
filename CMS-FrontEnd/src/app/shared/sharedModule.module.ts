import { DateParserPipe } from './pipes/date-parser.pipe';
import { TableComponent } from './components/table/table.component';
import { NgModule } from '@angular/core';
import { AngularMaterialModulesModule } from '../material/angular-material-modules/angular-material-modules.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { TranslateModule } from '@ngx-translate/core';

@NgModule({
  imports: [
    CommonModule,
    AngularMaterialModulesModule,
    FormsModule,
    ReactiveFormsModule,
    TranslateModule.forChild({ extend: true }),
  ],
  declarations: [TableComponent, DateParserPipe],
  exports: [TableComponent, DateParserPipe],
})
export class SharedModule {}
