import { Component } from '@angular/core';
import { AbstractControl, FormControl, FormGroup } from '@angular/forms';
import { Store } from '@ngrx/store';
import { Observable } from 'rxjs';
import { AddLetterAction } from './state/app.actions';
import { State } from './state/app.reducer';
import { valueSelector } from './state/app.selectors';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  public value$: Observable<string> = this.store.select(valueSelector);
  public form: FormGroup;

  constructor(public store: Store<State>) {
    this.form = new FormGroup({input: new FormControl()});
  }

  public setValue(string: string) {
    this.store.dispatch(AddLetterAction({ value: string }));
  }
}
