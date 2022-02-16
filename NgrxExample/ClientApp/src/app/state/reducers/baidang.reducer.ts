import { Action, createReducer, createSelector, on } from "@ngrx/store";
import { baidang } from "src/app/models/baidang";
import * as BaidangAction from "../actions/baidang.action";
import { AppState } from "../app.state";

export interface BaidangState {
    list: baidang[],
    loading: boolean
}
export const initialState = {
    list: [] as baidang[],
    loading: false
};
export const BaidangReducer = createReducer(
    initialState,
    on(BaidangAction.FECTH_BAIDANG, state => (
        {
            ...state, loading: true
        }
    )),
    on(BaidangAction.FECTH_BAIDANG_SUCCESS, (state, { baidangs }) => (
        {
            ...state,
            list: baidangs,
            loading: false
        }
    )),
    on(BaidangAction.FECTH_BAIDANG_FAILURE, state => (
        {
            ...state, loading: false
        }
    ))
);

export function bdreducer(state: BaidangState | undefined, action: Action) {
    return BaidangReducer(state, action)
}
const getBaidangfeatureState = (state: AppState) => state.baidang;
export const getBaidangs = createSelector(
    getBaidangfeatureState,
    (state: BaidangState) => state.list
)