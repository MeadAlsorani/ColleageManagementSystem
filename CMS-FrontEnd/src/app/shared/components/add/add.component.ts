import { BaseComponent } from './../Base.component';
import {
  Component,
  Input,
  OnInit,
  Injector,
  Output,
  EventEmitter,
} from '@angular/core';
import { FormField } from '../../interfaces/FormField';
import { FormControl, FormGroup, Validators } from '@angular/forms';

@Component({
  selector: 'app-add',
  templateUrl: './add.component.html',
  styleUrls: ['./add.component.less'],
})
export class AddComponent extends BaseComponent implements OnInit {
  _fields: FormField[] = [];
  @Output() submitFormEmitter = new EventEmitter();
  @Output() valueChangeEmitter = new EventEmitter();
  @Input() set fields(fields: FormField[]) {
    if (fields != null && fields.length > 0) {
      this._fields = fields;
      if (this.formGroup == null) this.formGroup = this.formBuilder.group({});
      fields.forEach((field) => {
        if (!this.formGroup.contains(field.code)) {
          this.formGroup.addControl(field.code, new FormControl(null));
          if (field.required === true)
            this.formGroup.get(field.code)?.addValidators(Validators.required);
        }
      });
    }
  }
  get fields() {
    return this._fields;
  }
  formGroup!: FormGroup;
  isLoading = false;
  constructor(injector: Injector) {
    super(injector);
  }

  ngOnInit() {
    this.formGroup.valueChanges.subscribe((change) => {
      this.valueChangeEmitter.emit(change);
    });
  }
  submit() {
    this.isLoading = true;
    this.submitFormEmitter.emit(this.formGroup.value);
  }
}
