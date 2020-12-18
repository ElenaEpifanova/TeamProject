var items = new vis.DataSet({type: { start: 'ISODate', end: 'ISODate' }});
var groups = new vis.DataSet
([
{id: 'bar',
content: 'График',subgroupStack: { sg_1: true},
subgroupVisibility: { sg_1: true}}
]);
items.add(
[{id: 1,
content: 'Автогрейдер',
start: '2020-12-20T08:00:00' ,
end: '2020-12-20T08:30:00',
group: 'bar',
subgroup: 'sg_1',
subgroupOrder: 0 },
]);
var container = document.getElementById('visualization'); 
var options = { 
start:'2020-12-19',
end:'2020-12-28' ,
};
var timeline = new vis.Timeline(container, items, groups, options); 