import { BaseComponent } from './../Base.component';
import {
  Component,
  EventEmitter,
  Injector,
  Input,
  OnInit,
  Output,
} from '@angular/core';
import { FormControl, Validators, FormGroup } from '@angular/forms';
import { FormField } from '../../interfaces/FormField';

@Component({
  selector: 'app-edit',
  templateUrl: './edit.component.html',
  styleUrls: ['./edit.component.less'],
})
export class EditComponent extends BaseComponent implements OnInit {
  @Output() submitFormEmitter = new EventEmitter();
  @Input() fields: FormField[] = [];
  @Input() formGroup!: FormGroup;
  constructor(injector: Injector) {
    super(injector);
  }

  ngOnInit() {}
  submit() {
    this.submitFormEmitter.emit(this.formGroup.value);
  }
}
