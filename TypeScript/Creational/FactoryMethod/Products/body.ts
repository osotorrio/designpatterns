import { IPagePart } from "./IPartPage";

export class Body implements IPagePart {
    width: number = 100;
    heigh: number = 500;
    content: string = "This is a BODY"

    public render(): void {
        console.log(`${this.content}\n${this.width}pixels width\n${this.heigh}pixels height`);
    }
}