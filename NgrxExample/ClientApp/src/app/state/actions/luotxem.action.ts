import { createAction, props } from "@ngrx/store";
import { luotxem } from "src/app/models/luotxem";

export enum LuotxemActionType {
    Fecth_luotxem = "[Luotxem] Fecth luot xem",
    Fecth_luotxem_success = "[Luotxem] Fecth luot xem success",
    Fecth_luotxem_fail = "[Luotxem] Fecth luot xem failure"
}
export const FECTH_LUOTXEM = createAction(
    LuotxemActionType.Fecth_luotxem
)
export const FECTH_LUOTXEM_SUCCESS = createAction(
    LuotxemActionType.Fecth_luotxem_success,
    props<{ luotxems: luotxem[] }>()
)
export const FETCH_LUOTXEM_FAIL = createAction(
    LuotxemActionType.Fecth_luotxem_fail
)