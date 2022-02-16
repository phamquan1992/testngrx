import { createAction, props } from "@ngrx/store";
import { taikhoan } from "src/app/models/taikhoan";

export enum TaikhoanActionType {
    Fecth_taikhoan = "[TAIKHOAN] Fecth tai khoan",
    Fecth_taikhoan_success = "[TAIKHOAN] Fecth tai khoan success",
    Fecth_taikhoan_fail = "[Taikhoan] Fecth tai khoan failure"
}
export const FECTH_TAIKHOAN = createAction(
    TaikhoanActionType.Fecth_taikhoan
)
export const FECHT_TAIKHOAN_SUCCESS = createAction(
    TaikhoanActionType.Fecth_taikhoan_success,
    props<{ taikhoans: taikhoan[] }>()
)
export const FECTH_TAIKHOAN_FAIL = createAction(
    TaikhoanActionType.Fecth_taikhoan_fail
)
