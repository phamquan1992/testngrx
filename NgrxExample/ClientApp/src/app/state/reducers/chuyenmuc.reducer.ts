import { createReducer, on } from "@ngrx/store";
import { chuyenmuc } from "src/app/models/chuyenmuc";
import * as ChuyenmucAction from '../actions/chuyenmuc.action'

export interface ChuyenmucState {
    list: chuyenmuc[],
    loading: boolean
}
export const initialState = {
    list: [] as chuyenmuc[],
    loading: false
};
export const ChuyenmucReducer = createReducer(
    initialState,
    on(ChuyenmucAction.FECTH_CHUYENMUC, state => (
        {
            ...state,
            loading: true
        }
    )),
    on(ChuyenmucAction.FECTH_CHUYENMUC_SUCCESS, (state, { chuyenmucs }) => (
        {
            ...state,
            loading: false,
            list: chuyenmucs
        }
    )),
    on(ChuyenmucAction.FECTH_CHUYENMUC_FAIL, state => (
        {
            ...state,
            loading: false
        }
    ))
);
