import { IPagePart } from "../Products/IPartPage";

export abstract class AbstractPage {
    constructor(){
        this.assemblyPage();
    }

    private _pageParts: Array<IPagePart> = [];

    get parts(){
        return this._pageParts;
    }

    public abstract assemblyPage(): void;
}