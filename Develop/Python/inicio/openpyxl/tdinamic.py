from openpyxl import Workbook
from openpyxl import load_workbook
from openpyxl.chart import BarChart, ScatterChart, Reference, Series
import openpyxl
import pandas as pd


#CREAR LA TABLA DINAMICA
#-----------------------
file=pd.read_excel("base.xlsx")
#print (file[['MUNICIPIO','LOCALIDAD','MONTOCONTRATADO']])

piv=file.pivot_table(index='MUNICIPIO', columns='EJERCICIO', 
values='MONTOCONTRATADO',aggfunc='sum').round(0)
#manda a un archivo nuevo
piv.to_excel('base1.xlsx',startrow=1,sheet_name="Hoja1")



#MANIPULAR EL ARCHIVO DE EXCEL
#-----------------------------
wb=load_workbook('base1.xlsx')
sh=wb['Hoja1']

#establece los rangos de la tabla pivote
minc=wb.active.min_column
maxc=wb.active.max_column
minr=wb.active.min_row
maxr=wb.active.max_row

#print(minc,maxc,minr,maxr)