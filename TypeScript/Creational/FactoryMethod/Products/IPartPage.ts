export interface IPagePart {
    width: number;
    heigh: number;
    content: string;
    render(): void;
}