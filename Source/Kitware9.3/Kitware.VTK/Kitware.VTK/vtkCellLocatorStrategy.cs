using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCellLocatorStrategy
	/// </summary>
	/// <remarks>
	///    implement a specific vtkPointSet::FindCell() strategy based
	///          on using a cell locator
	///
	/// vtkCellLocatorStrategy is implements a FindCell() strategy based on
	/// using the FindCell() method in a cell locator. This is often the
	/// slowest strategy, but the most robust.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkFindCellStrategy vtkPointSet
	/// </seealso>
	// Token: 0x02000A2A RID: 2602
	public class vtkCellLocatorStrategy : vtkFindCellStrategy
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601B1A6 RID: 111014 RVA: 0x0025D5AF File Offset: 0x0025B7AF
		static vtkCellLocatorStrategy()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCellLocatorStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellLocatorStrategy"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601B1A7 RID: 111015 RVA: 0x0025D5D7 File Offset: 0x0025B7D7
		public vtkCellLocatorStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601B1A8 RID: 111016
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellLocatorStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct a vtkFindCellStrategy subclass.
		/// </summary>
		// Token: 0x0601B1A9 RID: 111017 RVA: 0x0025D5E8 File Offset: 0x0025B7E8
		public new static vtkCellLocatorStrategy New()
		{
			vtkCellLocatorStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellLocatorStrategy.vtkCellLocatorStrategy_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellLocatorStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct a vtkFindCellStrategy subclass.
		/// </summary>
		// Token: 0x0601B1AA RID: 111018 RVA: 0x0025D63C File Offset: 0x0025B83C
		public vtkCellLocatorStrategy() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCellLocatorStrategy.vtkCellLocatorStrategy_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601B1AB RID: 111019 RVA: 0x0025D680 File Offset: 0x0025B880
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601B1AC RID: 111020
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellLocatorStrategy_CopyParameters_01(HandleRef pThis, HandleRef from);

		/// <summary>
		/// Copy essential parameters between instances of this class. This
		/// generally is used to copy from instance prototype to another, or to copy
		/// strategies between thread instances.  Sub-classes can contribute to
		/// the parameter copying process via chaining.
		/// </summary>
		// Token: 0x0601B1AD RID: 111021 RVA: 0x0025D68C File Offset: 0x0025B88C
		public override void CopyParameters(vtkFindCellStrategy from)
		{
			vtkCellLocatorStrategy.vtkCellLocatorStrategy_CopyParameters_01(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis());
		}

		// Token: 0x0601B1AE RID: 111022
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellLocatorStrategy_FindCell_02(HandleRef pThis, IntPtr x, HandleRef cell, HandleRef gencell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Implement the specific strategy.
		/// </summary>
		// Token: 0x0601B1AF RID: 111023 RVA: 0x0025D6BC File Offset: 0x0025B8BC
		public override long FindCell(IntPtr x, vtkCell cell, vtkGenericCell gencell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights)
		{
			return vtkCellLocatorStrategy.vtkCellLocatorStrategy_FindCell_02(base.GetCppThis(), x, (cell == null) ? default(HandleRef) : cell.GetCppThis(), (gencell == null) ? default(HandleRef) : gencell.GetCppThis(), cellId, tol2, ref subId, pcoords, weights);
		}

		// Token: 0x0601B1B0 RID: 111024
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellLocatorStrategy_FindClosestPointWithinRadius_03(HandleRef pThis, IntPtr x, double radius, IntPtr closestPoint, HandleRef cell, ref long cellId, ref int subId, ref double dist2, ref int inside);

		/// <summary>
		/// Implement the specific strategy.
		/// </summary>
		// Token: 0x0601B1B1 RID: 111025 RVA: 0x0025D710 File Offset: 0x0025B910
		public override long FindClosestPointWithinRadius(IntPtr x, double radius, IntPtr closestPoint, vtkGenericCell cell, ref long cellId, ref int subId, ref double dist2, ref int inside)
		{
			return vtkCellLocatorStrategy.vtkCellLocatorStrategy_FindClosestPointWithinRadius_03(base.GetCppThis(), x, radius, closestPoint, (cell == null) ? default(HandleRef) : cell.GetCppThis(), ref cellId, ref subId, ref dist2, ref inside);
		}

		// Token: 0x0601B1B2 RID: 111026
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellLocatorStrategy_GetCellLocator_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set / get an instance of vtkAbstractCellLocator which is used to
		/// implement the strategy for FindCell(). The locator is required to
		/// already be built and non-NULL.
		/// </summary>
		// Token: 0x0601B1B3 RID: 111027 RVA: 0x0025D754 File Offset: 0x0025B954
		public virtual vtkAbstractCellLocator GetCellLocator()
		{
			vtkAbstractCellLocator vtkAbstractCellLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellLocatorStrategy.vtkCellLocatorStrategy_GetCellLocator_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractCellLocator = (vtkAbstractCellLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractCellLocator.Register(null);
				}
			}
			return vtkAbstractCellLocator;
		}

		// Token: 0x0601B1B4 RID: 111028
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellLocatorStrategy_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0601B1B5 RID: 111029 RVA: 0x0025D7C4 File Offset: 0x0025B9C4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCellLocatorStrategy.vtkCellLocatorStrategy_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x0601B1B6 RID: 111030
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellLocatorStrategy_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0601B1B7 RID: 111031 RVA: 0x0025D7E4 File Offset: 0x0025B9E4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCellLocatorStrategy.vtkCellLocatorStrategy_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0601B1B8 RID: 111032
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellLocatorStrategy_Initialize_07(HandleRef pThis, HandleRef ps);

		/// <summary>
		/// Provide necessary initialization method (see superclass for more
		/// information).
		/// </summary>
		// Token: 0x0601B1B9 RID: 111033 RVA: 0x0025D800 File Offset: 0x0025BA00
		public override int Initialize(vtkPointSet ps)
		{
			return vtkCellLocatorStrategy.vtkCellLocatorStrategy_Initialize_07(base.GetCppThis(), (ps == null) ? default(HandleRef) : ps.GetCppThis());
		}

		// Token: 0x0601B1BA RID: 111034
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkCellLocatorStrategy_InsideCellBounds_08(HandleRef pThis, IntPtr x, long cellId);

		/// <summary>
		/// Implement the specific strategy.
		/// </summary>
		// Token: 0x0601B1BB RID: 111035 RVA: 0x0025D834 File Offset: 0x0025BA34
		public override bool InsideCellBounds(IntPtr x, long cellId)
		{
			return vtkCellLocatorStrategy.vtkCellLocatorStrategy_InsideCellBounds_08(base.GetCppThis(), x, cellId) != 0;
		}

		// Token: 0x0601B1BC RID: 111036
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellLocatorStrategy_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0601B1BD RID: 111037 RVA: 0x0025D85C File Offset: 0x0025BA5C
		public override int IsA(string type)
		{
			return vtkCellLocatorStrategy.vtkCellLocatorStrategy_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x0601B1BE RID: 111038
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellLocatorStrategy_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0601B1BF RID: 111039 RVA: 0x0025D87C File Offset: 0x0025BA7C
		public new static int IsTypeOf(string type)
		{
			return vtkCellLocatorStrategy.vtkCellLocatorStrategy_IsTypeOf_10(type);
		}

		// Token: 0x0601B1C0 RID: 111040
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellLocatorStrategy_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0601B1C1 RID: 111041 RVA: 0x0025D898 File Offset: 0x0025BA98
		public new vtkCellLocatorStrategy NewInstance()
		{
			vtkCellLocatorStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellLocatorStrategy.vtkCellLocatorStrategy_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellLocatorStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601B1C2 RID: 111042
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellLocatorStrategy_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0601B1C3 RID: 111043 RVA: 0x0025D8F4 File Offset: 0x0025BAF4
		public new static vtkCellLocatorStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkCellLocatorStrategy vtkCellLocatorStrategy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellLocatorStrategy.vtkCellLocatorStrategy_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellLocatorStrategy = (vtkCellLocatorStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellLocatorStrategy.Register(null);
				}
			}
			return vtkCellLocatorStrategy;
		}

		// Token: 0x0601B1C4 RID: 111044
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellLocatorStrategy_SetCellLocator_14(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set / get an instance of vtkAbstractCellLocator which is used to
		/// implement the strategy for FindCell(). The locator is required to
		/// already be built and non-NULL.
		/// </summary>
		// Token: 0x0601B1C5 RID: 111045 RVA: 0x0025D974 File Offset: 0x0025BB74
		public virtual void SetCellLocator(vtkAbstractCellLocator arg0)
		{
			vtkCellLocatorStrategy.vtkCellLocatorStrategy_SetCellLocator_14(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D47 RID: 7495
		public new const string MRFullTypeName = "Kitware.VTK.vtkCellLocatorStrategy";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D48 RID: 7496
		public new static readonly string MRClassNameKey = "class vtkCellLocatorStrategy";
	}
}
