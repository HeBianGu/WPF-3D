using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCellAttribute
	/// </summary>
	/// <remarks>
	///    A function defined over the physical domain of a vtkCellGrid.
	///
	/// This is a base class for attributes (functions) defined on the space
	/// discretized by a vtkCellGrid. A vtkCellAttribute class must handle
	/// cells of all types present in the grid.
	///
	/// </remarks>
	/// <seealso>
	///  vtkCellGrid
	/// </seealso>
	// Token: 0x02000A15 RID: 2581
	public class vtkCellAttribute : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601AE3A RID: 110138 RVA: 0x002578FF File Offset: 0x00255AFF
		static vtkCellAttribute()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCellAttribute.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellAttribute"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601AE3B RID: 110139 RVA: 0x00257927 File Offset: 0x00255B27
		public vtkCellAttribute(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601AE3C RID: 110140
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellAttribute_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AE3D RID: 110141 RVA: 0x00257938 File Offset: 0x00255B38
		public new static vtkCellAttribute New()
		{
			vtkCellAttribute result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellAttribute.vtkCellAttribute_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellAttribute)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AE3E RID: 110142 RVA: 0x0025798C File Offset: 0x00255B8C
		public vtkCellAttribute() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCellAttribute.vtkCellAttribute_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601AE3F RID: 110143 RVA: 0x002579D0 File Offset: 0x00255BD0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601AE40 RID: 110144
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellAttribute_GetArrayForCellTypeAndRole_01(HandleRef pThis, vtkStringToken cellType, vtkStringToken arrayRole, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Return an array for the given cell type and role.
		///
		/// This is a convenience for use in language bindings like Python.
		/// </summary>
		// Token: 0x0601AE41 RID: 110145 RVA: 0x002579DC File Offset: 0x00255BDC
		public vtkAbstractArray GetArrayForCellTypeAndRole(vtkStringToken cellType, vtkStringToken arrayRole)
		{
			vtkAbstractArray vtkAbstractArray = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellAttribute.vtkCellAttribute_GetArrayForCellTypeAndRole_01(base.GetCppThis(), cellType, arrayRole, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractArray = (vtkAbstractArray)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractArray.Register(null);
				}
			}
			return vtkAbstractArray;
		}

		// Token: 0x0601AE42 RID: 110146
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkStringToken vtkCellAttribute_GetAttributeType_02(HandleRef pThis);

		/// <summary>
		/// Return a (user-presentable) type for this attribute.
		///
		/// The type should reflect the nature of the function and
		/// may reflect the nature of the cell shapes supported.
		///
		/// The type is distinct from the space in which values reside;
		/// instead it describes the mathematical technique used to
		/// interpolate values (e.g., "rational spline", "polynomial",
		/// "partition of unity", "stochastic", etc.), behavior at cell
		/// boundaries, and other relevant information.
		/// For example, a quadratic field that allows discontinuities
		/// at cell boundaries and uses H(Grad) Lagrange interpolation
		/// of arbitrary order (i.e., order may differ per cell) might
		/// return "DG HGRAD [CI]n", where "n" indicates the integration
		/// order is arbitrary. The "C" or "I" preceding the order
		/// indicates the basis is "complete (C)" or "incomplete (I)."
		///
		/// Currently, this is just a free-form string but in the future
		/// we may adopt a more rigorous standard.
		/// </summary>
		// Token: 0x0601AE43 RID: 110147 RVA: 0x00257A50 File Offset: 0x00255C50
		public virtual vtkStringToken GetAttributeType()
		{
			return vtkCellAttribute.vtkCellAttribute_GetAttributeType_02(base.GetCppThis());
		}

		// Token: 0x0601AE44 RID: 110148
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellAttribute_GetColormap_03(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the arrays required to evaluate this attribute on cells
		/// of the given type.
		///
		/// TODO: Instead of accepting a fixed type (ArraysForCellType), this method
		///       should be templated to accept any object so that cell types can put
		///       whatever state is needed here in order to assist in evaluating the
		///       attribute.
		/// </summary>
		// Token: 0x0601AE45 RID: 110149 RVA: 0x00257A70 File Offset: 0x00255C70
		public vtkScalarsToColors GetColormap()
		{
			vtkScalarsToColors vtkScalarsToColors = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellAttribute.vtkCellAttribute_GetColormap_03(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkScalarsToColors = (vtkScalarsToColors)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkScalarsToColors.Register(null);
				}
			}
			return vtkScalarsToColors;
		}

		// Token: 0x0601AE46 RID: 110150
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern uint vtkCellAttribute_GetHash_04(HandleRef pThis);

		/// <summary>
		/// Hash this attribute so it can be inserted into unordered containers.
		///
		/// The hash includes the name, type, space, and number of components.
		/// </summary>
		// Token: 0x0601AE47 RID: 110151 RVA: 0x00257AE0 File Offset: 0x00255CE0
		public virtual uint GetHash()
		{
			return vtkCellAttribute.vtkCellAttribute_GetHash_04(base.GetCppThis());
		}

		// Token: 0x0601AE48 RID: 110152
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellAttribute_GetId_05(HandleRef pThis);

		/// <summary>
		/// Return a (cell-grid-assigned) integer identifier for this attribute.
		///
		/// Do not call SetId() unless you represent a vtkCellGrid taking
		/// ownership of this attribute instance.
		/// </summary>
		// Token: 0x0601AE49 RID: 110153 RVA: 0x00257B00 File Offset: 0x00255D00
		public virtual int GetId()
		{
			return vtkCellAttribute.vtkCellAttribute_GetId_05(base.GetCppThis());
		}

		// Token: 0x0601AE4A RID: 110154
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkStringToken vtkCellAttribute_GetName_06(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AE4B RID: 110155 RVA: 0x00257B20 File Offset: 0x00255D20
		public virtual vtkStringToken GetName()
		{
			return vtkCellAttribute.vtkCellAttribute_GetName_06(base.GetCppThis());
		}

		// Token: 0x0601AE4C RID: 110156
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellAttribute_GetNumberOfComponents_07(HandleRef pThis);

		/// <summary>
		/// Return the number of components this function provides
		/// at each point in space.
		///
		/// This should be consistent with the value returned by GetSpace().
		/// </summary>
		// Token: 0x0601AE4D RID: 110157 RVA: 0x00257B40 File Offset: 0x00255D40
		public virtual int GetNumberOfComponents()
		{
			return vtkCellAttribute.vtkCellAttribute_GetNumberOfComponents_07(base.GetCppThis());
		}

		// Token: 0x0601AE4E RID: 110158
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellAttribute_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AE4F RID: 110159 RVA: 0x00257B60 File Offset: 0x00255D60
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCellAttribute.vtkCellAttribute_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x0601AE50 RID: 110160
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellAttribute_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AE51 RID: 110161 RVA: 0x00257B80 File Offset: 0x00255D80
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCellAttribute.vtkCellAttribute_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x0601AE52 RID: 110162
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern vtkStringToken vtkCellAttribute_GetSpace_10(HandleRef pThis);

		/// <summary>
		/// Return a token identifying the space containing all field values.
		///
		/// Currently, this is just a free-form string but in the future
		/// we may adopt a more rigorous standard.
		///
		/// Some suggested values
		/// + "ℝ¹" – single (scalar) values over the real numbers.
		/// + "ℝ¹+" – single (scalar) values over the non-negative real numbers.
		/// + "ℝ²" – 2-d vector values over the real numbers.
		/// + "ℝ³" – 3-d vector values over the real numbers.
		/// + "𝕊³" – points inside a unit 3-dimensional ball.
		/// + "S²" – points on the surface of a unit 3-dimensional sphere.
		/// + "SO(3)" – rotation matrices.
		/// + "SU(2)" – special unitary group (homeomorphic to SO(3)).
		///
		/// Note that the space might imply the number of components but
		/// it also specifies how users should interpret operations such
		/// as addition and/or multipliciation, especially in the case of
		/// transforms applied to the domain.
		/// </summary>
		// Token: 0x0601AE53 RID: 110163 RVA: 0x00257B9C File Offset: 0x00255D9C
		public virtual vtkStringToken GetSpace()
		{
			return vtkCellAttribute.vtkCellAttribute_GetSpace_10(base.GetCppThis());
		}

		// Token: 0x0601AE54 RID: 110164
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCellAttribute_Initialize_11(HandleRef pThis, vtkStringToken name, vtkStringToken attributeType, vtkStringToken space, int numberOfComponents);

		/// <summary>
		/// Initialize an attribute.
		///
		/// Never call this method after a cell-attribute has been inserted
		/// into an unordered container as it will change the reported hash,
		/// which can cause crashes later.
		/// </summary>
		// Token: 0x0601AE55 RID: 110165 RVA: 0x00257BBC File Offset: 0x00255DBC
		public virtual bool Initialize(vtkStringToken name, vtkStringToken attributeType, vtkStringToken space, int numberOfComponents)
		{
			return vtkCellAttribute.vtkCellAttribute_Initialize_11(base.GetCppThis(), name, attributeType, space, numberOfComponents) != 0;
		}

		// Token: 0x0601AE56 RID: 110166
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellAttribute_IsA_12(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AE57 RID: 110167 RVA: 0x00257BE8 File Offset: 0x00255DE8
		public override int IsA(string type)
		{
			return vtkCellAttribute.vtkCellAttribute_IsA_12(base.GetCppThis(), type);
		}

		// Token: 0x0601AE58 RID: 110168
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellAttribute_IsTypeOf_13([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AE59 RID: 110169 RVA: 0x00257C08 File Offset: 0x00255E08
		public new static int IsTypeOf(string type)
		{
			return vtkCellAttribute.vtkCellAttribute_IsTypeOf_13(type);
		}

		// Token: 0x0601AE5A RID: 110170
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellAttribute_NewInstance_15(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AE5B RID: 110171 RVA: 0x00257C24 File Offset: 0x00255E24
		public new vtkCellAttribute NewInstance()
		{
			vtkCellAttribute result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellAttribute.vtkCellAttribute_NewInstance_15(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellAttribute)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601AE5C RID: 110172
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellAttribute_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601AE5D RID: 110173 RVA: 0x00257C80 File Offset: 0x00255E80
		public new static vtkCellAttribute SafeDownCast(vtkObjectBase o)
		{
			vtkCellAttribute vtkCellAttribute = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellAttribute.vtkCellAttribute_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellAttribute = (vtkCellAttribute)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellAttribute.Register(null);
				}
			}
			return vtkCellAttribute;
		}

		// Token: 0x0601AE5E RID: 110174
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCellAttribute_SetColormap_17(HandleRef pThis, HandleRef colormap);

		/// <summary>
		/// Set the arrays required to evaluate this attribute on cells
		/// of the given type.
		///
		/// TODO: Instead of accepting a fixed type (ArraysForCellType), this method
		///       should be templated to accept any object so that cell types can put
		///       whatever state is needed here in order to assist in evaluating the
		///       attribute.
		/// </summary>
		// Token: 0x0601AE5F RID: 110175 RVA: 0x00257D00 File Offset: 0x00255F00
		public bool SetColormap(vtkScalarsToColors colormap)
		{
			return vtkCellAttribute.vtkCellAttribute_SetColormap_17(base.GetCppThis(), (colormap == null) ? default(HandleRef) : colormap.GetCppThis()) != 0;
		}

		// Token: 0x0601AE60 RID: 110176
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellAttribute_SetId_18(HandleRef pThis, int _arg);

		/// <summary>
		/// Return a (cell-grid-assigned) integer identifier for this attribute.
		///
		/// Do not call SetId() unless you represent a vtkCellGrid taking
		/// ownership of this attribute instance.
		/// </summary>
		// Token: 0x0601AE61 RID: 110177 RVA: 0x00257D3B File Offset: 0x00255F3B
		public virtual void SetId(int _arg)
		{
			vtkCellAttribute.vtkCellAttribute_SetId_18(base.GetCppThis(), _arg);
		}

		// Token: 0x0601AE62 RID: 110178
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellAttribute_ShallowCopy_19(HandleRef pThis, HandleRef other);

		/// <summary>
		/// Copy data from an \a other attribute instance into this instance.
		///
		/// Currently, the only difference between shallow and deep copies is
		/// that the colormap is copied by reference when shallow-copying and
		/// a cloned instance is created when deep-copying.
		///
		/// Note that the list of array pointers is copied by reference
		/// (even when deep-copying a vtkCellAttribute) unless you provide
		/// DeepCopy() with a map of \a arrayRewrites pointers. The
		/// vtkCellGrid owns the arrays, not the vtkCellAttribute, so the
		/// when deep-copying a vtkCellGrid, it will have a map of array
		/// copies it has created. If any array is mentioned in \a AllArrays
		/// and is not present in \a arrayRewrites, it is copied by reference.
		/// </summary>
		// Token: 0x0601AE63 RID: 110179 RVA: 0x00257D4C File Offset: 0x00255F4C
		public virtual void ShallowCopy(vtkCellAttribute other)
		{
			vtkCellAttribute.vtkCellAttribute_ShallowCopy_19(base.GetCppThis(), (other == null) ? default(HandleRef) : other.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D02 RID: 7426
		public new const string MRFullTypeName = "Kitware.VTK.vtkCellAttribute";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D03 RID: 7427
		public new static readonly string MRClassNameKey = "class vtkCellAttribute";
	}
}
