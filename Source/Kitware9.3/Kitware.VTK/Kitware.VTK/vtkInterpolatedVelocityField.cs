using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkInterpolatedVelocityField
	/// </summary>
	/// <remarks>
	///    A concrete class for obtaining
	///  the interpolated velocity values at a point.
	///
	///
	/// vtkInterpolatedVelocityField acts as a continuous velocity field via
	/// cell interpolation on a vtkDataSet, NumberOfIndependentVariables = 4
	/// (x,y,z,t) and NumberOfFunctions = 3 (u,v,w). As a concrete sub-class
	/// of vtkCompositeInterpolatedVelocityField, this class adopts two levels
	/// of cell caching for faster though less robust cell location than its
	/// sibling class vtkCellLocatorInterpolatedVelocityField. Level #0 begins
	/// with intra-cell caching. Specifically, if the previous cell is valid
	/// and the next point is still within it, ( vtkCell::EvaluatePosition()
	/// returns 1, coupled with the new parametric coordinates and weights ),
	/// the function values are interpolated and vtkCell::EvaluatePosition()
	/// is invoked only. If it fails, level #1 follows by inter-cell location
	/// of the target cell (that contains the next point). By inter-cell, the
	/// previous cell gives an important clue / guess or serves as an immediate
	/// neighbor to aid in the location of the target cell (as is typically the
	/// case with integrating a streamline across cells) by means of vtkDataSet::
	/// FindCell(). If this still fails, a global cell search is invoked via
	/// vtkDataSet::FindCell().
	///
	/// Regardless of inter-cell or global search, a point locator is employed as
	/// a crucial tool underlying the interpolation process. The use of a point
	/// locator, while faster than a cell locator, is not optimal and may cause
	/// vtkInterpolatedVelocityField to return incorrect results (i.e., premature
	/// streamline termination) for datasets defined on complex grids (especially
	/// those this discontinuous/incompatible cells). In these cases, try
	/// vtkCellLocatorInterpolatedVelocityField which produces the best results at
	/// the cost of speed.
	///
	/// @warning
	/// vtkInterpolatedVelocityField is not thread safe. A new instance should be
	/// created by each thread.
	///
	/// </remarks>
	/// <seealso>
	///
	///  vtkCompositeInterpolatedVelocityField vtkCellLocatorInterpolatedVelocityField
	///  vtkGenericInterpolatedVelocityField vtkCachingInterpolatedVelocityField
	///  vtkTemporalInterpolatedVelocityField vtkFunctionSet vtkStreamTracer
	/// </seealso>
	// Token: 0x020004AD RID: 1197
	public class vtkInterpolatedVelocityField : vtkCompositeInterpolatedVelocityField
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600DC2C RID: 56364 RVA: 0x0013162B File Offset: 0x0012F82B
		static vtkInterpolatedVelocityField()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkInterpolatedVelocityField.MRClassNameKey, Type.GetType("Kitware.VTK.vtkInterpolatedVelocityField"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600DC2D RID: 56365 RVA: 0x00131653 File Offset: 0x0012F853
		public vtkInterpolatedVelocityField(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600DC2E RID: 56366
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInterpolatedVelocityField_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct a vtkCompositeInterpolatedVelocityField subclass.
		/// </summary>
		// Token: 0x0600DC2F RID: 56367 RVA: 0x00131664 File Offset: 0x0012F864
		public new static vtkInterpolatedVelocityField New()
		{
			vtkInterpolatedVelocityField result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInterpolatedVelocityField.vtkInterpolatedVelocityField_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInterpolatedVelocityField)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct a vtkCompositeInterpolatedVelocityField subclass.
		/// </summary>
		// Token: 0x0600DC30 RID: 56368 RVA: 0x001316B8 File Offset: 0x0012F8B8
		public vtkInterpolatedVelocityField() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkInterpolatedVelocityField.vtkInterpolatedVelocityField_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600DC31 RID: 56369 RVA: 0x001316FC File Offset: 0x0012F8FC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600DC32 RID: 56370
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInterpolatedVelocityField_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0600DC33 RID: 56371 RVA: 0x00131708 File Offset: 0x0012F908
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkInterpolatedVelocityField.vtkInterpolatedVelocityField_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600DC34 RID: 56372
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkInterpolatedVelocityField_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0600DC35 RID: 56373 RVA: 0x00131728 File Offset: 0x0012F928
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkInterpolatedVelocityField.vtkInterpolatedVelocityField_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600DC36 RID: 56374
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInterpolatedVelocityField_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0600DC37 RID: 56375 RVA: 0x00131744 File Offset: 0x0012F944
		public override int IsA(string type)
		{
			return vtkInterpolatedVelocityField.vtkInterpolatedVelocityField_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0600DC38 RID: 56376
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkInterpolatedVelocityField_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0600DC39 RID: 56377 RVA: 0x00131764 File Offset: 0x0012F964
		public new static int IsTypeOf(string type)
		{
			return vtkInterpolatedVelocityField.vtkInterpolatedVelocityField_IsTypeOf_04(type);
		}

		// Token: 0x0600DC3A RID: 56378
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInterpolatedVelocityField_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0600DC3B RID: 56379 RVA: 0x00131780 File Offset: 0x0012F980
		public new vtkInterpolatedVelocityField NewInstance()
		{
			vtkInterpolatedVelocityField result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInterpolatedVelocityField.vtkInterpolatedVelocityField_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkInterpolatedVelocityField)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600DC3C RID: 56380
		[DllImport("Kitware.VTK.FiltersFlowPaths.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkInterpolatedVelocityField_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0600DC3D RID: 56381 RVA: 0x001317DC File Offset: 0x0012F9DC
		public new static vtkInterpolatedVelocityField SafeDownCast(vtkObjectBase o)
		{
			vtkInterpolatedVelocityField vtkInterpolatedVelocityField = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkInterpolatedVelocityField.vtkInterpolatedVelocityField_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkInterpolatedVelocityField = (vtkInterpolatedVelocityField)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkInterpolatedVelocityField.Register(null);
				}
			}
			return vtkInterpolatedVelocityField;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001011 RID: 4113
		public new const string MRFullTypeName = "Kitware.VTK.vtkInterpolatedVelocityField";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001012 RID: 4114
		public new static readonly string MRClassNameKey = "class vtkInterpolatedVelocityField";
	}
}
