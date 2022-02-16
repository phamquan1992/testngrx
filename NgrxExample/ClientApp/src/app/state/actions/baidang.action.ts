import { createAction, props } from "@ngrx/store";
import { baidang } from "src/app/models/baidang";

export enum BaidangActionType {
    Fecth_baidang = "[BAIDANG] Fecth bai dang",
    Fecth_baidang_success = "[BAIDANG] Fecth bai dang success",
    Fecth_baidang_fail = "[BAIDANG] Fecth bai dang failure",
    Get_baidang_obj = "[BAIDANG] Get bai dang",
    Get_baidang_obj_success = "[BAIDANG] Get bai dang success",
    Get_baidang_obj_fail = "[BAIDANG] Get bai dang failure"
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
export const GET_BAIDANG_OBJ = createAction(
    BaidangActionType.Get_baidang_obj,
    props<{url:string}>()
)
export const GET_BAIDANG_OBJ_SUCCESS = createAction(
    BaidangActionType.Get_baidang_obj_success,
    props<{ bai_dang: baidang }>()
)
export const GET_BAIDANG_OBJ_FAIL = createAction(
    BaidangActionType.Get_baidang_obj_fail
)

