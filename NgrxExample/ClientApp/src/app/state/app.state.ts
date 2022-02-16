import { BaidangState } from "./reducers/baidang.reducer";
import { ChuyenmucState } from "./reducers/chuyenmuc.reducer";


export interface AppState{
    baidang:BaidangState,
    chuyenmuc:ChuyenmucState
}