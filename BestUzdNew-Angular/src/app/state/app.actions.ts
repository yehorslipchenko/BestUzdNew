import { createAction, props } from "@ngrx/store";

export enum AppActions {
    AddLetter = '[App] Add letter'
}

export const AddLetterAction = createAction(AppActions.AddLetter, props<{value: string}>())
