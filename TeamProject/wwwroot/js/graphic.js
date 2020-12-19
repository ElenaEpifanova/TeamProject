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
start: '2020-12-19T08:00:00' ,
end: '2020-12-19T08:30:00',
group: 'bar',
subgroup: 'sg_1',
subgroupOrder: 0 },
]);
var container = document.getElementById('visualization'); 
var options = { 
start:'2020-12-18',
end:'2020-12-23' ,
};
var timeline = new vis.Timeline(container, items, groups, options); 