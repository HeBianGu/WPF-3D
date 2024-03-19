using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkPieceScalars
	/// </summary>
	/// <remarks>
	///    Sets all cell scalars from the update piece.
	///
	///
	/// vtkPieceScalars is meant to display which piece is being requested
	/// as scalar values.  It is useful for visualizing the partitioning for
	/// streaming or distributed pipelines.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkPolyDataStreamer
	/// </seealso>
	// Token: 0x02000516 RID: 1302
	public class vtkPieceScalars : vtkDataSetAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E8C6 RID: 59590 RVA: 0x00144A2C File Offset: 0x00142C2C
		static vtkPieceScalars()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkPieceScalars.MRClassNameKey, Type.GetType("Kitware.VTK.vtkPieceScalars"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E8C7 RID: 59591 RVA: 0x00144A54 File Offset: 0x00142C54
		public vtkPieceScalars(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600E8C8 RID: 59592
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPieceScalars_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E8C9 RID: 59593 RVA: 0x00144A64 File Offset: 0x00142C64
		public new static vtkPieceScalars New()
		{
			vtkPieceScalars result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPieceScalars.vtkPieceScalars_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPieceScalars)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E8CA RID: 59594 RVA: 0x00144AB8 File Offset: 0x00142CB8
		public vtkPieceScalars() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkPieceScalars.vtkPieceScalars_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E8CB RID: 59595 RVA: 0x00144AFC File Offset: 0x00142CFC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E8CC RID: 59596
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPieceScalars_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E8CD RID: 59597 RVA: 0x00144B08 File Offset: 0x00142D08
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkPieceScalars.vtkPieceScalars_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0600E8CE RID: 59598
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkPieceScalars_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E8CF RID: 59599 RVA: 0x00144B28 File Offset: 0x00142D28
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkPieceScalars.vtkPieceScalars_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0600E8D0 RID: 59600
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPieceScalars_GetRandomMode_03(HandleRef pThis);

		/// <summary>
		/// Option to centerate cell scalars of points scalars.  Default is point scalars.
		/// </summary>
		// Token: 0x0600E8D1 RID: 59601 RVA: 0x00144B44 File Offset: 0x00142D44
		public virtual int GetRandomMode()
		{
			return vtkPieceScalars.vtkPieceScalars_GetRandomMode_03(base.GetCppThis());
		}

		// Token: 0x0600E8D2 RID: 59602
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPieceScalars_GetScalarMode_04(HandleRef pThis);

		/// <summary>
		/// Option to centerate cell scalars of points scalars.  Default is point scalars.
		/// </summary>
		// Token: 0x0600E8D3 RID: 59603 RVA: 0x00144B64 File Offset: 0x00142D64
		public int GetScalarMode()
		{
			return vtkPieceScalars.vtkPieceScalars_GetScalarMode_04(base.GetCppThis());
		}

		// Token: 0x0600E8D4 RID: 59604
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPieceScalars_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E8D5 RID: 59605 RVA: 0x00144B84 File Offset: 0x00142D84
		public override int IsA(string type)
		{
			return vtkPieceScalars.vtkPieceScalars_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x0600E8D6 RID: 59606
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkPieceScalars_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E8D7 RID: 59607 RVA: 0x00144BA4 File Offset: 0x00142DA4
		public new static int IsTypeOf(string type)
		{
			return vtkPieceScalars.vtkPieceScalars_IsTypeOf_06(type);
		}

		// Token: 0x0600E8D8 RID: 59608
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPieceScalars_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E8D9 RID: 59609 RVA: 0x00144BC0 File Offset: 0x00142DC0
		public new vtkPieceScalars NewInstance()
		{
			vtkPieceScalars result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPieceScalars.vtkPieceScalars_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkPieceScalars)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E8DA RID: 59610
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPieceScalars_RandomModeOff_09(HandleRef pThis);

		/// <summary>
		/// Option to centerate cell scalars of points scalars.  Default is point scalars.
		/// </summary>
		// Token: 0x0600E8DB RID: 59611 RVA: 0x00144C1A File Offset: 0x00142E1A
		public virtual void RandomModeOff()
		{
			vtkPieceScalars.vtkPieceScalars_RandomModeOff_09(base.GetCppThis());
		}

		// Token: 0x0600E8DC RID: 59612
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPieceScalars_RandomModeOn_10(HandleRef pThis);

		/// <summary>
		/// Option to centerate cell scalars of points scalars.  Default is point scalars.
		/// </summary>
		// Token: 0x0600E8DD RID: 59613 RVA: 0x00144C29 File Offset: 0x00142E29
		public virtual void RandomModeOn()
		{
			vtkPieceScalars.vtkPieceScalars_RandomModeOn_10(base.GetCppThis());
		}

		// Token: 0x0600E8DE RID: 59614
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkPieceScalars_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E8DF RID: 59615 RVA: 0x00144C38 File Offset: 0x00142E38
		public new static vtkPieceScalars SafeDownCast(vtkObjectBase o)
		{
			vtkPieceScalars vtkPieceScalars = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkPieceScalars.vtkPieceScalars_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkPieceScalars = (vtkPieceScalars)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkPieceScalars.Register(null);
				}
			}
			return vtkPieceScalars;
		}

		// Token: 0x0600E8E0 RID: 59616
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPieceScalars_SetRandomMode_12(HandleRef pThis, int _arg);

		/// <summary>
		/// Option to centerate cell scalars of points scalars.  Default is point scalars.
		/// </summary>
		// Token: 0x0600E8E1 RID: 59617 RVA: 0x00144CB7 File Offset: 0x00142EB7
		public virtual void SetRandomMode(int _arg)
		{
			vtkPieceScalars.vtkPieceScalars_SetRandomMode_12(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E8E2 RID: 59618
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPieceScalars_SetScalarModeToCellData_13(HandleRef pThis);

		/// <summary>
		/// Option to centerate cell scalars of points scalars.  Default is point scalars.
		/// </summary>
		// Token: 0x0600E8E3 RID: 59619 RVA: 0x00144CC7 File Offset: 0x00142EC7
		public void SetScalarModeToCellData()
		{
			vtkPieceScalars.vtkPieceScalars_SetScalarModeToCellData_13(base.GetCppThis());
		}

		// Token: 0x0600E8E4 RID: 59620
		[DllImport("Kitware.VTK.FiltersParallel.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkPieceScalars_SetScalarModeToPointData_14(HandleRef pThis);

		/// <summary>
		/// Option to centerate cell scalars of points scalars.  Default is point scalars.
		/// </summary>
		// Token: 0x0600E8E5 RID: 59621 RVA: 0x00144CD6 File Offset: 0x00142ED6
		public void SetScalarModeToPointData()
		{
			vtkPieceScalars.vtkPieceScalars_SetScalarModeToPointData_14(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001116 RID: 4374
		public new const string MRFullTypeName = "Kitware.VTK.vtkPieceScalars";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001117 RID: 4375
		public new static readonly string MRClassNameKey = "class vtkPieceScalars";
	}
}
