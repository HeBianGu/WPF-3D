using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCellLocatorInterpolatedVelocityField
	/// </summary>
	/// <remarks>
	///    A concrete class for
	///  obtaining the interpolated velocity values at a point.
	///
	///
	///  vtkCellLocatorInterpolatedVelocityField acts as a continuous velocity
	///  field via cell interpolation on a vtkDataSet, NumberOfIndependentVariables
	///  = 4 (x,y,z,t) and NumberOfFunctions = 3 (u,v,w). As a concrete sub-class
	///  of vtkCompositeInterpolatedVelocityField, it adopts vtkAbstractCellLocator's
	///  sub-classes, e.g., vtkCellLocator and vtkModifiedBSPTree, without the use
	///  of vtkPointLocator ( employed by vtkDataSet::FindCell() and
	///  vtkPointSet::FindCell() in vtkInterpolatedVelocityField ).
	///  vtkCellLocatorInterpolatedVelocityField adopts one level of cell caching.
	///  Specifically, if the next point is still within the previous cell, cell
	///  location is then simply skipped and vtkCell:: EvaluatePosition() is called
	///  to obtain the new parametric coordinates and weights that are used to
	///  interpolate the velocity function values across the vertices of this cell.
	///  Otherwise a global cell (the target containing the next point) location is
	///  instead directly invoked, without exploiting the clue that
	///  vtkInterpolatedVelocityField makes use of from the previous cell (an
	///  immediate neighbor). Although ignoring the neighbor cell may incur a
	///  relatively high computational cost, vtkCellLocatorInterpolatedVelocityField
	///  is more robust in locating the target cell than its sibling class
	///  vtkInterpolatedVelocityField.
	///
	/// @warning
	///  vtkCellLocatorInterpolatedVelocityField is not thread safe. A new instance
	///  should be created by each thread.
	///
	/// </remarks>
	/// <seealso>
	///
	///  vtkCompositeInterpolatedVelocityField vtkInterpolatedVelocityField
	///  vtkGenericInterpolatedVelocityField vtkCachingInterpolatedVelocityField
	///  vtkTemporalInterpolatedVelocityField vtkFunctionSet vtkStreamTracer
	/// </seealso>
	// Token: 0x020004AB RID: 1195
	public class vtkCellLocatorInterpolatedVelocityField : vtkCompositeInterpolatedVelocityField
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600DBC2 RID: 56258 RVA: 0x00130E01 File Offset: 0x0012F001
		static vtkCellLocatorInterpolatedVelocityField()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCellLocatorInterpolatedVelocityField.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellLocatorInterpolatedVelocityField"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600DBC3 RID: 56259 RVA: 0x00130E29 File Offset: 0x0012F029
		public vtkCellLocatorInterpolatedVelocityField(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600DBC4 RID: 56260
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellLocatorInterpolatedVelocityField_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct a vtkCompositeInterpolatedVelocityField subclass.
		/// </summary>
		// Token: 0x0600DBC5 RID: 56261 RVA: 0x00130E38 File Offset: 0x0012F038
		public new static vtkCellLocatorInterpolatedVelocityField New()
		{
			vtkCellLocatorInterpolatedVelocityField result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellLocatorInterpolatedVelocityField.vtkCellLocatorInterpolatedVelocityField_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellLocatorInterpolatedVelocityField)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct a vtkCompositeInterpolatedVelocityField subclass.
		/// </summary>
		// Token: 0x0600DBC6 RID: 56262 RVA: 0x00130E8C File Offset: 0x0012F08C
		public vtkCellLocatorInterpolatedVelocityField() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCellLocatorInterpolatedVelocityField.vtkCellLocatorInterpolatedVelocityField_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600DBC7 RID: 56263 RVA: 0x00130ED0 File Offset: 0x0012F0D0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600DBC8 RID: 56264
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellLocatorInterpolatedVelocityField_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0600DBC9 RID: 56265 RVA: 0x00130EDC File Offset: 0x0012F0DC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCellLocatorInterpolatedVelocityField.vtkCellLocatorInterpolatedVelocityField_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600DBCA RID: 56266
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellLocatorInterpolatedVelocityField_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0600DBCB RID: 56267 RVA: 0x00130EFC File Offset: 0x0012F0FC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCellLocatorInterpolatedVelocityField.vtkCellLocatorInterpolatedVelocityField_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600DBCC RID: 56268
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellLocatorInterpolatedVelocityField_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0600DBCD RID: 56269 RVA: 0x00130F18 File Offset: 0x0012F118
		public override int IsA(string type)
		{
			return vtkCellLocatorInterpolatedVelocityField.vtkCellLocatorInterpolatedVelocityField_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600DBCE RID: 56270
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellLocatorInterpolatedVelocityField_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0600DBCF RID: 56271 RVA: 0x00130F38 File Offset: 0x0012F138
		public new static int IsTypeOf(string type)
		{
			return vtkCellLocatorInterpolatedVelocityField.vtkCellLocatorInterpolatedVelocityField_IsTypeOf_04(type);
		}

		// Token: 0x0600DBD0 RID: 56272
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellLocatorInterpolatedVelocityField_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0600DBD1 RID: 56273 RVA: 0x00130F54 File Offset: 0x0012F154
		public new vtkCellLocatorInterpolatedVelocityField NewInstance()
		{
			vtkCellLocatorInterpolatedVelocityField result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellLocatorInterpolatedVelocityField.vtkCellLocatorInterpolatedVelocityField_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellLocatorInterpolatedVelocityField)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600DBD2 RID: 56274
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellLocatorInterpolatedVelocityField_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0600DBD3 RID: 56275 RVA: 0x00130FB0 File Offset: 0x0012F1B0
		public new static vtkCellLocatorInterpolatedVelocityField SafeDownCast(vtkObjectBase o)
		{
			vtkCellLocatorInterpolatedVelocityField vtkCellLocatorInterpolatedVelocityField = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellLocatorInterpolatedVelocityField.vtkCellLocatorInterpolatedVelocityField_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellLocatorInterpolatedVelocityField = (vtkCellLocatorInterpolatedVelocityField)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellLocatorInterpolatedVelocityField.Register(null);
				}
			}
			return vtkCellLocatorInterpolatedVelocityField;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400100D RID: 4109
		public new const string MRFullTypeName = "Kitware.VTK.vtkCellLocatorInterpolatedVelocityField";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400100E RID: 4110
		public new static readonly string MRClassNameKey = "class vtkCellLocatorInterpolatedVelocityField";
	}
}
