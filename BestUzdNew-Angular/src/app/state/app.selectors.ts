import { createFeatureSelector, createSelector } from '@ngrx/store';
import { appFeatureKey, initialState, State } from './app.reducer';

const featureState = createFeatureSelector<State>(appFeatureKey);

export const valueSelector = createSelector(
  featureState,
  (state: State) => state.prop
);