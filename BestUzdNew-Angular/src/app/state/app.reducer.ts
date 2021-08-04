import { Action, createReducer, on } from '@ngrx/store';
import { AddLetterAction } from './app.actions';

export const appFeatureKey = 'app';

export interface State {
  prop: string
}

export const initialState: State = {
  prop: "test"
};

const featureReducer = createReducer(
  initialState,
  on(
    AddLetterAction,
    (state, a) => ({ ...state, ...{ prop: a.value } })
  ),
);

export function reducer(state: State | undefined, action: Action) {
  return featureReducer(state, action);
}
