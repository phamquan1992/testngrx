import { createAction, props } from "@ngrx/store";
import { theloai } from "src/app/models/theloai";

export enum TheloaiActionType {
    Fecth_theloai = "[THELOAI] fecth the loai",
    Fecth_theloai_success = "[THELOAI] fecth the loai success",
    Fecth_theloai_fail = "[THELOAI] fecth the loai failure"
}
export const FECTH_THELOAI = createAction(
    TheloaiActionType.Fecth_theloai
)
export const FECTH_THELOAI_SUCCESS = createAction(
    TheloaiActionType.Fecth_theloai,
    props<{ theloais: theloai[] }>()
)
export const FECTH_THELOAI_FAIL = createAction(
    TheloaiActionType.Fecth_theloai_fail
)