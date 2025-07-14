# 🖥️ ABM de Electrodomésticos - WinForms

Este proyecto es una aplicación de escritorio desarrollada con **C# y Windows Forms**, conectada a una base de datos en **SQL Server**. Permite realizar operaciones de **Alta, Baja (lógica y definitiva), Modificación y Consulta** sobre productos de una casa de electrodomésticos.

---

## 📌 Funcionalidades principales

- ✅ Alta de productos con validaciones
- 🔄 Modificación (excepto del código)
- ❌ Baja lógica (stock en 0)
- 🗑️ Baja definitiva (eliminación real del registro)
- 🔍 Consulta general y por código
- 📊 Visualización de stock en grilla (solo si stock > 1)
- 🧼 Botón para limpiar campos y refrescar grilla

---

## 🧪 Tecnologías usadas

- C# (.NET Framework)
- Windows Forms
- SQL Server
- ADO.NET

---

## 🗃️ Base de datos

**Nombre:** `Electrodomesticos_DB`  
**Tabla:** `Electrodomestico`

```sql
CREATE TABLE Electrodomestico
(
    Id INT IDENTITY(1,1) PRIMARY KEY,
    electrodomesticos_codigo VARCHAR(10),
    electrodomesticos_tipo VARCHAR(50),
    electrodomesticos_marca VARCHAR(50),
    electrodomesticos_modelo VARCHAR(50),
    electrodomesticos_caracteristicas VARCHAR(255),
    electrodomesticos_cantidad_stock INT,
    electrodomesticos_precio DECIMAL(10,2),
    electrodomesticos_fecha_ingreso DATETIME
);
