export function ShowPrompt(element,DotNetReference) {
    element.addEventListner('click', () => {
        DotNetReference.invokeMethodAsync('IncrementCount')
    });
}