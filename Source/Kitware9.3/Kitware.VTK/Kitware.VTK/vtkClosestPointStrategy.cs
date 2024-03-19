using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkClosestPointStrategy
	/// </summary>
	/// <remarks>
	///    implement a specific vtkPointSet::FindCell() strategy based
	///          on closest point
	///
	/// vtkClosestPointStrategy is implements a FindCell() strategy based on
	/// locating the closest point in a dataset, and then searching the attached
	/// cells. While relatively fast, it does not always return the correct result
	/// (it may not find a cell, since the closest cell may not be connected to the
	/// closest point). vtkCellLocatorStrategy or vtkClosestNPointsStrategy will
	/// produce better results at the cost of speed.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkFindCellStrategy vtkPointSet vtkCellLocatorStrategy
	/// vtkClosestNPointsStrategy
	/// </seealso>
	// Token: 0x02000A2D RID: 2605
	public class vtkClosestPointStrategy : vtkFindCellStrategy
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601B22A RID: 111146 RVA: 0x0025E32B File Offset: 0x0025C52B
		static vtkClosestPointStrategy()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkClosestPointStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkClosestPointStrategy"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601B22B RID: 111147 RVA: 0x0025E353 File Offset: 0x0025C553
		public vtkClosestPointStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601B22C RID: 111148
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkClosestPointStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct a vtkFindCellStrategy subclass.
		/// </summary>
		// Token: 0x0601B22D RID: 111149 RVA: 0x0025E364 File Offset: 0x0025C564
		public new static vtkClosestPointStrategy New()
		{
			vtkClosestPointStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkClosestPointStrategy.vtkClosestPointStrategy_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkClosestPointStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct a vtkFindCellStrategy subclass.
		/// </summary>
		// Token: 0x0601B22E RID: 111150 RVA: 0x0025E3B8 File Offset: 0x0025C5B8
		public vtkClosestPointStrategy() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkClosestPointStrategy.vtkClosestPointStrategy_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601B22F RID: 111151 RVA: 0x0025E3FC File Offset: 0x0025C5FC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601B230 RID: 111152
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClosestPointStrategy_CopyParameters_01(HandleRef pThis, HandleRef from);

		/// <summary>
		/// Copy essential parameters between instances of this class. This
		/// generally is used to copy from instance prototype to another, or to copy
		/// strategies between thread instances.  Sub-classes can contribute to
		/// the parameter copying process via chaining.
		/// </summary>
		// Token: 0x0601B231 RID: 111153 RVA: 0x0025E408 File Offset: 0x0025C608
		public override void CopyParameters(vtkFindCellStrategy from)
		{
			vtkClosestPointStrategy.vtkClosestPointStrategy_CopyParameters_01(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis());
		}

		// Token: 0x0601B232 RID: 111154
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkClosestPointStrategy_FindCell_02(HandleRef pThis, IntPtr x, HandleRef cell, HandleRef gencell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Implement the specific strategy. This method should only be called
		/// after the Initialize() method has been invoked.
		/// </summary>
		// Token: 0x0601B233 RID: 111155 RVA: 0x0025E438 File Offset: 0x0025C638
		public override long FindCell(IntPtr x, vtkCell cell, vtkGenericCell gencell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights)
		{
			return vtkClosestPointStrategy.vtkClosestPointStrategy_FindCell_02(base.GetCppThis(), x, (cell == null) ? default(HandleRef) : cell.GetCppThis(), (gencell == null) ? default(HandleRef) : gencell.GetCppThis(), cellId, tol2, ref subId, pcoords, weights);
		}

		// Token: 0x0601B234 RID: 111156
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkClosestPointStrategy_FindClosestPointWithinRadius_03(HandleRef pThis, IntPtr x, double radius, IntPtr closestPoint, HandleRef cell, ref long cellId, ref int subId, ref double dist2, ref int inside);

		/// <summary>
		/// Implement the specific strategy. This method should only be called
		/// after the Initialize() method has been invoked.
		/// </summary>
		// Token: 0x0601B235 RID: 111157 RVA: 0x0025E48C File Offset: 0x0025C68C
		public override long FindClosestPointWithinRadius(IntPtr x, double radius, IntPtr closestPoint, vtkGenericCell cell, ref long cellId, ref int subId, ref double dist2, ref int inside)
		{
			return vtkClosestPointStrategy.vtkClosestPointStrategy_FindClosestPointWithinRadius_03(base.GetCppThis(), x, radius, closestPoint, (cell == null) ? default(HandleRef) : cell.GetCppThis(), ref cellId, ref subId, ref dist2, ref inside);
		}

		// Token: 0x0601B236 RID: 111158
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkClosestPointStrategy_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0601B237 RID: 111159 RVA: 0x0025E4D0 File Offset: 0x0025C6D0
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkClosestPointStrategy.vtkClosestPointStrategy_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0601B238 RID: 111160
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkClosestPointStrategy_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0601B239 RID: 111161 RVA: 0x0025E4F0 File Offset: 0x0025C6F0
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkClosestPointStrategy.vtkClosestPointStrategy_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0601B23A RID: 111162
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkClosestPointStrategy_GetPointLocator_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set / get an instance of vtkAbstractPointLocator which is used to
		/// implement the strategy for FindCell(). Note if a locator is not
		/// specified, then the default locator instantiated by the vtkPointSet
		/// provided in the Initialize() method is used.
		/// </summary>
		// Token: 0x0601B23B RID: 111163 RVA: 0x0025E50C File Offset: 0x0025C70C
		public virtual vtkAbstractPointLocator GetPointLocator()
		{
			vtkAbstractPointLocator vtkAbstractPointLocator = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkClosestPointStrategy.vtkClosestPointStrategy_GetPointLocator_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkAbstractPointLocator = (vtkAbstractPointLocator)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkAbstractPointLocator.Register(null);
				}
			}
			return vtkAbstractPointLocator;
		}

		// Token: 0x0601B23C RID: 111164
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkClosestPointStrategy_Initialize_07(HandleRef pThis, HandleRef ps);

		/// <summary>
		/// Provide the necessary initialization method (see superclass for more
		/// information). This method sets up the point locator, vtkPointSet relationship.
		/// It will use the vtkPointSet's default locator if not defined by
		/// SetPointLocator() below.
		/// </summary>
		// Token: 0x0601B23D RID: 111165 RVA: 0x0025E57C File Offset: 0x0025C77C
		public override int Initialize(vtkPointSet ps)
		{
			return vtkClosestPointStrategy.vtkClosestPointStrategy_Initialize_07(base.GetCppThis(), (ps == null) ? default(HandleRef) : ps.GetCppThis());
		}

		// Token: 0x0601B23E RID: 111166
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkClosestPointStrategy_InsideCellBounds_08(HandleRef pThis, IntPtr x, long cellId);

		/// <summary>
		/// Implement the specific strategy.
		/// </summary>
		// Token: 0x0601B23F RID: 111167 RVA: 0x0025E5B0 File Offset: 0x0025C7B0
		public override bool InsideCellBounds(IntPtr x, long cellId)
		{
			return vtkClosestPointStrategy.vtkClosestPointStrategy_InsideCellBounds_08(base.GetCppThis(), x, cellId) != 0;
		}

		// Token: 0x0601B240 RID: 111168
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkClosestPointStrategy_IsA_09(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0601B241 RID: 111169 RVA: 0x0025E5D8 File Offset: 0x0025C7D8
		public override int IsA(string type)
		{
			return vtkClosestPointStrategy.vtkClosestPointStrategy_IsA_09(base.GetCppThis(), type);
		}

		// Token: 0x0601B242 RID: 111170
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkClosestPointStrategy_IsTypeOf_10([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0601B243 RID: 111171 RVA: 0x0025E5F8 File Offset: 0x0025C7F8
		public new static int IsTypeOf(string type)
		{
			return vtkClosestPointStrategy.vtkClosestPointStrategy_IsTypeOf_10(type);
		}

		// Token: 0x0601B244 RID: 111172
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkClosestPointStrategy_NewInstance_12(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0601B245 RID: 111173 RVA: 0x0025E614 File Offset: 0x0025C814
		public new vtkClosestPointStrategy NewInstance()
		{
			vtkClosestPointStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkClosestPointStrategy.vtkClosestPointStrategy_NewInstance_12(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkClosestPointStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601B246 RID: 111174
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkClosestPointStrategy_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0601B247 RID: 111175 RVA: 0x0025E670 File Offset: 0x0025C870
		public new static vtkClosestPointStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkClosestPointStrategy vtkClosestPointStrategy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkClosestPointStrategy.vtkClosestPointStrategy_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkClosestPointStrategy = (vtkClosestPointStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkClosestPointStrategy.Register(null);
				}
			}
			return vtkClosestPointStrategy;
		}

		// Token: 0x0601B248 RID: 111176
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkClosestPointStrategy_SelectCell_14(HandleRef pThis, HandleRef self, long cellId, HandleRef cell, HandleRef gencell, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Subclasses use this method to select the current cell.
		/// </summary>
		// Token: 0x0601B249 RID: 111177 RVA: 0x0025E6F0 File Offset: 0x0025C8F0
		public vtkCell SelectCell(vtkPointSet self, long cellId, vtkCell cell, vtkGenericCell gencell)
		{
			vtkCell vtkCell = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkClosestPointStrategy.vtkClosestPointStrategy_SelectCell_14(base.GetCppThis(), (self == null) ? default(HandleRef) : self.GetCppThis(), cellId, (cell == null) ? default(HandleRef) : cell.GetCppThis(), (gencell == null) ? default(HandleRef) : gencell.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCell = (vtkCell)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCell.Register(null);
				}
			}
			return vtkCell;
		}

		// Token: 0x0601B24A RID: 111178
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClosestPointStrategy_SetPointLocator_15(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Set / get an instance of vtkAbstractPointLocator which is used to
		/// implement the strategy for FindCell(). Note if a locator is not
		/// specified, then the default locator instantiated by the vtkPointSet
		/// provided in the Initialize() method is used.
		/// </summary>
		// Token: 0x0601B24B RID: 111179 RVA: 0x0025E7A4 File Offset: 0x0025C9A4
		public virtual void SetPointLocator(vtkAbstractPointLocator arg0)
		{
			vtkClosestPointStrategy.vtkClosestPointStrategy_SetPointLocator_15(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D4D RID: 7501
		public new const string MRFullTypeName = "Kitware.VTK.vtkClosestPointStrategy";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D4E RID: 7502
		public new static readonly string MRClassNameKey = "class vtkClosestPointStrategy";
	}
}
