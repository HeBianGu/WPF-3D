using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkClosestNPointsStrategy
	/// </summary>
	/// <remarks>
	///    implement a specific vtkPointSet::FindCell() strategy based
	///          on the N closest points
	///
	/// vtkClosestNPointsStrategy is implements a FindCell() strategy based on
	/// locating the closest N points in a dataset, and then searching attached
	/// cells. This class extends its superclass vtkClosestPointStrategy by looking
	/// at the additional N points.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkFindCellStrategy vtkPointSet
	/// </seealso>
	// Token: 0x02000A2E RID: 2606
	public class vtkClosestNPointsStrategy : vtkClosestPointStrategy
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601B24C RID: 111180 RVA: 0x0025E7D3 File Offset: 0x0025C9D3
		static vtkClosestNPointsStrategy()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkClosestNPointsStrategy.MRClassNameKey, Type.GetType("Kitware.VTK.vtkClosestNPointsStrategy"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601B24D RID: 111181 RVA: 0x0025E7FB File Offset: 0x0025C9FB
		public vtkClosestNPointsStrategy(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601B24E RID: 111182
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkClosestNPointsStrategy_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Construct a vtkFindCellStrategy subclass.
		/// </summary>
		// Token: 0x0601B24F RID: 111183 RVA: 0x0025E80C File Offset: 0x0025CA0C
		public new static vtkClosestNPointsStrategy New()
		{
			vtkClosestNPointsStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkClosestNPointsStrategy.vtkClosestNPointsStrategy_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkClosestNPointsStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Construct a vtkFindCellStrategy subclass.
		/// </summary>
		// Token: 0x0601B250 RID: 111184 RVA: 0x0025E860 File Offset: 0x0025CA60
		public vtkClosestNPointsStrategy() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkClosestNPointsStrategy.vtkClosestNPointsStrategy_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601B251 RID: 111185 RVA: 0x0025E8A4 File Offset: 0x0025CAA4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601B252 RID: 111186
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClosestNPointsStrategy_CopyParameters_01(HandleRef pThis, HandleRef from);

		/// <summary>
		/// Copy essential parameters between instances of this class. This
		/// generally is used to copy from instance prototype to another, or to copy
		/// strategies between thread instances.  Sub-classes can contribute to
		/// the parameter copying process via chaining.
		/// </summary>
		// Token: 0x0601B253 RID: 111187 RVA: 0x0025E8B0 File Offset: 0x0025CAB0
		public override void CopyParameters(vtkFindCellStrategy from)
		{
			vtkClosestNPointsStrategy.vtkClosestNPointsStrategy_CopyParameters_01(base.GetCppThis(), (from == null) ? default(HandleRef) : from.GetCppThis());
		}

		// Token: 0x0601B254 RID: 111188
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkClosestNPointsStrategy_FindCell_02(HandleRef pThis, IntPtr x, HandleRef cell, HandleRef gencell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights);

		/// <summary>
		/// Implement the specific strategy.
		/// </summary>
		// Token: 0x0601B255 RID: 111189 RVA: 0x0025E8E0 File Offset: 0x0025CAE0
		public override long FindCell(IntPtr x, vtkCell cell, vtkGenericCell gencell, long cellId, double tol2, ref int subId, IntPtr pcoords, IntPtr weights)
		{
			return vtkClosestNPointsStrategy.vtkClosestNPointsStrategy_FindCell_02(base.GetCppThis(), x, (cell == null) ? default(HandleRef) : cell.GetCppThis(), (gencell == null) ? default(HandleRef) : gencell.GetCppThis(), cellId, tol2, ref subId, pcoords, weights);
		}

		// Token: 0x0601B256 RID: 111190
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkClosestNPointsStrategy_GetClosestNPoints_03(HandleRef pThis);

		/// <summary>
		/// Set / get the value for the N closest points.
		/// </summary>
		// Token: 0x0601B257 RID: 111191 RVA: 0x0025E934 File Offset: 0x0025CB34
		public virtual int GetClosestNPoints()
		{
			return vtkClosestNPointsStrategy.vtkClosestNPointsStrategy_GetClosestNPoints_03(base.GetCppThis());
		}

		// Token: 0x0601B258 RID: 111192
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkClosestNPointsStrategy_GetClosestNPointsMaxValue_04(HandleRef pThis);

		/// <summary>
		/// Set / get the value for the N closest points.
		/// </summary>
		// Token: 0x0601B259 RID: 111193 RVA: 0x0025E954 File Offset: 0x0025CB54
		public virtual int GetClosestNPointsMaxValue()
		{
			return vtkClosestNPointsStrategy.vtkClosestNPointsStrategy_GetClosestNPointsMaxValue_04(base.GetCppThis());
		}

		// Token: 0x0601B25A RID: 111194
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkClosestNPointsStrategy_GetClosestNPointsMinValue_05(HandleRef pThis);

		/// <summary>
		/// Set / get the value for the N closest points.
		/// </summary>
		// Token: 0x0601B25B RID: 111195 RVA: 0x0025E974 File Offset: 0x0025CB74
		public virtual int GetClosestNPointsMinValue()
		{
			return vtkClosestNPointsStrategy.vtkClosestNPointsStrategy_GetClosestNPointsMinValue_05(base.GetCppThis());
		}

		// Token: 0x0601B25C RID: 111196
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkClosestNPointsStrategy_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0601B25D RID: 111197 RVA: 0x0025E994 File Offset: 0x0025CB94
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkClosestNPointsStrategy.vtkClosestNPointsStrategy_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x0601B25E RID: 111198
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkClosestNPointsStrategy_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0601B25F RID: 111199 RVA: 0x0025E9B4 File Offset: 0x0025CBB4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkClosestNPointsStrategy.vtkClosestNPointsStrategy_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x0601B260 RID: 111200
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkClosestNPointsStrategy_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0601B261 RID: 111201 RVA: 0x0025E9D0 File Offset: 0x0025CBD0
		public override int IsA(string type)
		{
			return vtkClosestNPointsStrategy.vtkClosestNPointsStrategy_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x0601B262 RID: 111202
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkClosestNPointsStrategy_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0601B263 RID: 111203 RVA: 0x0025E9F0 File Offset: 0x0025CBF0
		public new static int IsTypeOf(string type)
		{
			return vtkClosestNPointsStrategy.vtkClosestNPointsStrategy_IsTypeOf_09(type);
		}

		// Token: 0x0601B264 RID: 111204
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkClosestNPointsStrategy_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0601B265 RID: 111205 RVA: 0x0025EA0C File Offset: 0x0025CC0C
		public new vtkClosestNPointsStrategy NewInstance()
		{
			vtkClosestNPointsStrategy result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkClosestNPointsStrategy.vtkClosestNPointsStrategy_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkClosestNPointsStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601B266 RID: 111206
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkClosestNPointsStrategy_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Standard methods for type information and printing.
		/// </summary>
		// Token: 0x0601B267 RID: 111207 RVA: 0x0025EA68 File Offset: 0x0025CC68
		public new static vtkClosestNPointsStrategy SafeDownCast(vtkObjectBase o)
		{
			vtkClosestNPointsStrategy vtkClosestNPointsStrategy = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkClosestNPointsStrategy.vtkClosestNPointsStrategy_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkClosestNPointsStrategy = (vtkClosestNPointsStrategy)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkClosestNPointsStrategy.Register(null);
				}
			}
			return vtkClosestNPointsStrategy;
		}

		// Token: 0x0601B268 RID: 111208
		[DllImport("Kitware.VTK.CommonDataModel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkClosestNPointsStrategy_SetClosestNPoints_13(HandleRef pThis, int _arg);

		/// <summary>
		/// Set / get the value for the N closest points.
		/// </summary>
		// Token: 0x0601B269 RID: 111209 RVA: 0x0025EAE7 File Offset: 0x0025CCE7
		public virtual void SetClosestNPoints(int _arg)
		{
			vtkClosestNPointsStrategy.vtkClosestNPointsStrategy_SetClosestNPoints_13(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D4F RID: 7503
		public new const string MRFullTypeName = "Kitware.VTK.vtkClosestNPointsStrategy";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001D50 RID: 7504
		public new static readonly string MRClassNameKey = "class vtkClosestNPointsStrategy";
	}
}
