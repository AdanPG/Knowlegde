from openpyxl import Workbook
import openpyxl
from openpyxl.styles import Font
import time

from openpyxl.chart import ScatterChart, Reference, Series




#GENERAR LOS OBJETOS
boock=Workbook()
sheet=boock.active

sh3=boock.create_sheet("h3")

#boock2=Workbook()
#boock2=openpyxl.load_workbook("ruta")

#MANDAR DATOS A EXCEL
sheet['a1']="hola mundo"


for i in range(2,15):
    sheet[f'b{i}']=i**2






#FORMATO DE DATOS
sheet['a1'].font=Font(color='119B68')

tt=time.strftime("%x")
sheet['a2']=tt

sheet.merge_cells("d1:g1")
#sheet.unmerge_cells("d1:g1")

sheet["d1"]="celdas unidas"



#FORMULAS
sheet["b15"]='=sum(b2:b14)'



#GRAFICOS
sheet["A20"]='MESES'
sheet["A21"]='ENERO'
sheet["A22"]='FEBRERO'
sheet["A23"]='MARZO'

sheet["B20"]="VENTAS"
sheet["B21"]=343
sheet["B22"]=55
sheet["B23"]=125

c1=ScatterChart()
c1.title='ventas'
c1.style=13

c1.y_axis.title='ventas'
c1.x_axis.title='monto'

xvalues=Reference(sheet, min_col=1, min_row=21, max_col=1, max_row=23)
yvalues=Reference(sheet, min_col=2, min_row=21, max_col=2, max_row=23)

ss=Series(yvalues, xvalues, title='chart')
c1.series.append(ss)
sheet.add_chart(c1,'a30')


#SALVAR DATOS

boock.save(r"xxx.xlsx")