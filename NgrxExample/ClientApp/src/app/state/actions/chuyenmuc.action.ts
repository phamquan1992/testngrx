import { createAction, props } from "@ngrx/store";
import { chuyenmuc } from "src/app/models/chuyenmuc";

export enum ChuyenmucActionType {
    Fecth_chuyenmuc = "[CHUYENMUC] Fecth chuyen muc",
    Fecth_chuyenmuc_success = "[CHUYENMUC] Fecth chuyen muc success",
    Fecth_chuyenmuc_fail = "[CHUYENMUC] Fecth chuyen muc failure"
}

export const FECTH_CHUYENMUC = createAction(
    ChuyenmucActionType.Fecth_chuyenmuc
)
export const FECTH_CHUYENMUC_SUCCESS = createAction(
    ChuyenmucActionType.Fecth_chuyenmuc_success,
    props<{ chuyenmucs: chuyenmuc[] }>()
)
export const FECTH_CHUYENMUC_FAIL = createAction(
    ChuyenmucActionType.Fecth_chuyenmuc_fail
)