import { createAction, props } from "@ngrx/store";
import { baidang } from "src/app/models/baidang";

export enum BaidangActionType {
    Fecth_baidang = "[BAIDANG] Fecth bai dang",
    Fecth_baidang_success = "[BAIDANG] Fecth bai dang success",
    Fecth_baidang_fail = "[BAIDANG] Fecth bai dang failure"
}
export const FECTH_BAIDANG = createAction(
    BaidangActionType.Fecth_baidang
)
export const FECTH_BAIDANG_SUCCESS = createAction(
    BaidangActionType.Fecth_baidang_success,
    props<{ baidangs: baidang[] }>()
)
export const FECTH_BAIDANG_FAILURE = createAction(
    BaidangActionType.Fecth_baidang_fail
)