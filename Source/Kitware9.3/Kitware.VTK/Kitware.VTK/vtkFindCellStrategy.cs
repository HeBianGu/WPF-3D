using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkFindCellStrategy
	/// </summary>
	/// <remarks>
	///    helper class to manage the vtkPointSet::FindCell() METHOD
	///
	/// vtkFindCellStrategy is a helper class to manage the use of locators for
	/// locating cells containing a query point x[3], the so-called FindCell()
	/// method. The use of vtkDataSet::FindCell() is a common operation in
	/// applications such as streamline generation and probing. However, in some
	/// dataset types FindCell() can be implemented very simply (e.g.,
	/// vtkImageData) while in other datasets it is a complex operation requiring
	/// supplemental objects like locators to perform efficiently. In particular,
	/// vtkPointSet and its subclasses (like vtkUnstructuredGrid) require complex
	/// strategies to efficiently implement the FindCell() operation. Subclasses
	/// of the abstract vtkFindCellStrategy implement several of these strategies.
	///
	/// The are two key methods to this class and subclasses. The Initialize()
	/// method negotiates with an input dataset to define the locator to use:
	/// either a locator associated with the input dataset, or possibly an
	/// alternative locator defined by the strategy (subclasses of
	/// vtkFindCellStrategy do this). The second important method, FindCell()
	/// mimics vtkDataSet::FindCell() and can be used in place of it.
	///
	/// Note that vtkFindCellStrategy is in general not thread-safe as the
	/// strategies contain state used to accelerate the search process. Hence
	/// if multiple threads are attempting to invoke FindCell(), each thread
	/// needs to have its own instance of the vtkFindCellStrategy.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPointSet vtkPolyData vtkStructuredGrid vtkUnstructuredGrid
	/// vtkAbstractInterpolatedVelocityField vtkClosetPointStrategy
	/// vtkCellLocatorStrategy vtkClosestNPointsStrategy
	/// </seealso>
	// Token: 0x02000A29 RID: 2601
	public abstract class vtkFindCellStrategy : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601B18D RID: 110989 RVA: 0x0025D2F7 File Offset: 0x0025B4F7
		static vtkFindCellStrategy()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkFindCellStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkFindCellStrategy"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601B18E RID: 110990 RVA: 0x0025D31F File Offset: 0x0025B51F
		public vtkFindCellStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601B18F RID: 110991 RVA: 0x0025D32D File Offset: 0x0025B52D
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601B190 RID: 110992
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkFindCellStrategy_CopyParameters_01(HandleRef pThis, HandleRef from);

		/// <summary>
		/// Copy essential parameters between instances of this class. This
		/// generally is used to copy from instance prototype to another, or to copy
		/// strategies between thread instances.  Sub-classes can contribute to
		/// the parameter copying process via chaining.
		///
		/// Note: CopyParameters should ALWAYS be called BEFORE Initialize.
		/// </summary>
		// Token: 0x0601B191 RID: 110993 RVA: 0x0025D338 File Offset: 0x0025B538
		public virtual void CopyParameters(vtkFindCellStrategy from)
		{
			vtkFindCellStrategy.vtkFindCellStrategy_CopyParameters_01(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis());
		}

		// Token: 0x0601B192 RID: 110994
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFindCellStrategy_FindCell_02(HandleRef pThis, IntPtr x, HandleRef cell, HandleRef gencell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Virtual method for finding a cell. Subclasses must satisfy this API.
		/// This method is of the same signature as vtkDataSet::FindCell(). This
		/// method is not thread safe: separate instances of vtkFindCellStrategy
		/// should be created for each thread invoking FindCell(). This is done for
		/// performance reasons to reduce the number of objects created/destroyed on
		/// each FindCell() invocation.
		/// </summary>
		// Token: 0x0601B193 RID: 110995 RVA: 0x0025D368 File Offset: 0x0025B568
		public virtual long FindCell(IntPtr x, vtkCell cell, vtkGenericCell gencell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights)
		{
			return vtkFindCellStrategy.vtkFindCellStrategy_FindCell_02(base.GetCppThis(), x, (cell == null) ? default(HandleRef) : cell.GetCppThis(), (gencell == null) ? default(HandleRef) : gencell.GetCppThis(), cellId, tol2, ref subId, pcoords, weights);
		}

		// Token: 0x0601B194 RID: 110996
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFindCellStrategy_FindClosestPointWithinRadius_03(HandleRef pThis, IntPtr x, double radius, IntPtr closestPoint, HandleRef cell, ref long cellId, ref int subId, ref double dist2, ref int inside);

		/// <summary>
		/// Return the closest point within a specified radius and the cell which is
		/// closest to the point x. The closest point is somewhere on a cell, it
		/// need not be one of the vertices of the cell. This method returns 1 if a
		/// point is found within the specified radius. If there are no cells within
		/// the specified radius, the method returns 0 and the values of
		/// closestPoint, cellId, subId, and dist2 are undefined. This version takes
		/// in a vtkGenericCell to avoid allocating and deallocating the cell.  This
		/// is much faster than the version which does not take a *cell, especially
		/// when this function is called many times in a row such as by a for loop,
		/// where the allocation and dealloction can be done only once outside the
		/// for loop.  If a closest point is found, "cell" contains the points and
		/// ptIds for the cell "cellId" upon exit.  If a closest point is found,
		/// inside returns the return value of the EvaluatePosition call to the
		/// closest cell; inside(=1) or outside(=0).
		/// </summary>
		// Token: 0x0601B195 RID: 110997 RVA: 0x0025D3BC File Offset: 0x0025B5BC
		public virtual long FindClosestPointWithinRadius(IntPtr x, double radius, IntPtr closestPoint, vtkGenericCell cell, ref long cellId, ref int subId, ref double dist2, ref int inside)
		{
			return vtkFindCellStrategy.vtkFindCellStrategy_FindClosestPointWithinRadius_03(base.GetCppThis(), x, radius, closestPoint, (cell == null) ? default(HandleRef) : cell.GetCppThis(), ref cellId, ref subId, ref dist2, ref inside);
		}

		// Token: 0x0601B196 RID: 110998
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFindCellStrategy_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0601B197 RID: 110999 RVA: 0x0025D400 File Offset: 0x0025B600
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkFindCellStrategy.vtkFindCellStrategy_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x0601B198 RID: 111000
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkFindCellStrategy_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0601B199 RID: 111001 RVA: 0x0025D420 File Offset: 0x0025B620
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkFindCellStrategy.vtkFindCellStrategy_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x0601B19A RID: 111002
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFindCellStrategy_Initialize_06(HandleRef pThis, HandleRef ps);

		/// <summary>
		/// All subclasses of this class must provide an initialize method.  This
		/// method performs handshaking and setup between the vtkPointSet dataset
		/// and associated locator(s). A return value==0 means the initialization
		/// process failed. The initialization is set up in such a way as to prevent
		/// multiple locators from being built.
		/// </summary>
		// Token: 0x0601B19B RID: 111003 RVA: 0x0025D43C File Offset: 0x0025B63C
		public virtual int Initialize(vtkPointSet ps)
		{
			return vtkFindCellStrategy.vtkFindCellStrategy_Initialize_06(base.GetCppThis(), (ps == null) ? default(HandleRef) : ps.GetCppThis());
		}

		// Token: 0x0601B19C RID: 111004
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkFindCellStrategy_InsideCellBounds_07(HandleRef pThis, IntPtr x, long cellId);

		/// <summary>
		/// Quickly test if a point is inside the bounds of a particular cell.
		/// </summary>
		// Token: 0x0601B19D RID: 111005 RVA: 0x0025D470 File Offset: 0x0025B670
		public virtual bool InsideCellBounds(IntPtr x, long cellId)
		{
			return vtkFindCellStrategy.vtkFindCellStrategy_InsideCellBounds_07(base.GetCppThis(), x, cellId) != 0;
		}

		// Token: 0x0601B19E RID: 111006
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFindCellStrategy_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0601B19F RID: 111007 RVA: 0x0025D498 File Offset: 0x0025B698
		public override int IsA(string type)
		{
			return vtkFindCellStrategy.vtkFindCellStrategy_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x0601B1A0 RID: 111008
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkFindCellStrategy_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0601B1A1 RID: 111009 RVA: 0x0025D4B8 File Offset: 0x0025B6B8
		public new static int IsTypeOf(string type)
		{
			return vtkFindCellStrategy.vtkFindCellStrategy_IsTypeOf_09(type);
		}

		// Token: 0x0601B1A2 RID: 111010
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFindCellStrategy_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0601B1A3 RID: 111011 RVA: 0x0025D4D4 File Offset: 0x0025B6D4
		public new vtkFindCellStrategy NewInstance()
		{
			vtkFindCellStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFindCellStrategy.vtkFindCellStrategy_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkFindCellStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601B1A4 RID: 111012
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkFindCellStrategy_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0601B1A5 RID: 111013 RVA: 0x0025D530 File Offset: 0x0025B730
		public new static vtkFindCellStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkFindCellStrategy vtkFindCellStrategy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkFindCellStrategy.vtkFindCellStrategy_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkFindCellStrategy = (vtkFindCellStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkFindCellStrategy.Register(null);
				}
			}
			return vtkFindCellStrategy;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D45 RID: 7493
		public new const string MRFullTypeName = "Kitware.VTK.vtkFindCellStrategy";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D46 RID: 7494
		public new static readonly string MRClassNameKey = "class vtkFindCellStrategy";
	}
}
