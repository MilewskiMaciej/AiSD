## Wybór modelu:

|           | UAE-Large-V1 | paraphrase-multilingual-mpnet-base-v2 | LaBSE |
| --------- | ------------ | ------------------------------------- | ----- |
| Zero-Shot |	100% | 100% |	100% |
| Active Parameters |	0,304 |	0,086 |	0,086 |
| Total Parameters | 0,335 | 0,278 | 0,471 |
| Embedding Dimensions | 1024 | 768 | 768 |
| Max Tokens | 512 | 512 | 512 |
| Mean (Task) | 46,09 |	51,98 |	52,07 |
| Mean (TaskType) |	39,61 |	45,17 |	45,65 |
| Bitext Mining |	26,84 |	52,06 |	76,35 |
| Classification | 49,66 | 55,06 | 54,60 |
| Clustering | 41,87 | 40,19 | 38,08 |
Instruction Reranking	-2,14	-1,14	-3
Multilabel Classification	17,17	16,40	20,12
Pair Classification	72,82	81,15	75,97
Reranking	48,35	53,37	50,20
Retrieval	41,21	39,76	33,17
STS	60,75	69,66	65,35

Spośród wszystkich dostępnych modeli embeddingujących, najistotniejszym parametrem, po którym wszystkie modele zostały odfiltrowane, był Zero-Shot. Jest to istotny parametr, gdyż im wyższy procent, tym mniej model wymaga douczania. Zależało nam głównie na szybkości oraz jakości wyszukiwania danych, dlatego spośród odfiltrowanych modeli, skupiliśmy się na parametrze Retrieval, który pozwala na wysoką precyzję w kojarzeniu zapytań użytkownika w ramach wyszukiwania asymetrycznego (gdzie krótkie zapytanie musi zostać dopasowane do znacznie dłuższego dokumentu) oraz Active/Total Parameters, który świadczy o szybkości wyszukiwanych zapytań – im mniejsza liczba, tym szybciej. Ze względu na większą ilość Embedding Dimensions od pozostałych modeli, odrzuciliśmy model UAE-Large-V1, dzięki czemu model będzie jeszcze szybszy. Z pozostałych dwóch modeli finalnie zdecydowaliśmy się na model paraphrase-multilingual-mpnet-base-v2, ponieważ oferuje on optymalny balans pomiędzy precyzją a wydajnością obliczeniową. 
