using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCellGridElevation
	/// </summary>
	/// <remarks>
	///    Adds a cell attribute representing elevation.
	///
	/// This filter adds a new cell attribute – named "Elevation" by default –
	/// to an input vtkCellGrid. The cell attribute is scalar-valued and
	/// generally represents distance from some point along one or more axes.
	///
	/// In order to make the attribute more interesting for demonstration
	/// purposes, an additional "shock" parameter can be used by responders
	/// to introduce discontinuities in the attribute at cell boundaries
	/// (for cells which allow discontinuities such as vtkDGCell).
	/// </remarks>
	// Token: 0x020004CD RID: 1229
	public class vtkCellGridElevation : vtkCellGridAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600E00C RID: 57356 RVA: 0x00136C63 File Offset: 0x00134E63
		static vtkCellGridElevation()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCellGridElevation.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCellGridElevation"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0600E00D RID: 57357 RVA: 0x00136C8B File Offset: 0x00134E8B
		public vtkCellGridElevation(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0600E00E RID: 57358
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridElevation_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E00F RID: 57359 RVA: 0x00136C9C File Offset: 0x00134E9C
		public new static vtkCellGridElevation New()
		{
			vtkCellGridElevation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridElevation.vtkCellGridElevation_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellGridElevation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E010 RID: 57360 RVA: 0x00136CF0 File Offset: 0x00134EF0
		public vtkCellGridElevation() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCellGridElevation.vtkCellGridElevation_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0600E011 RID: 57361 RVA: 0x00136D34 File Offset: 0x00134F34
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0600E012 RID: 57362
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridElevation_GetAttributeName_01(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E013 RID: 57363 RVA: 0x00136D40 File Offset: 0x00134F40
		public virtual string GetAttributeName()
		{
			string s = Marshal.PtrToStringAnsi(vtkCellGridElevation.vtkCellGridElevation_GetAttributeName_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600E014 RID: 57364
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridElevation_GetAxis_02(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E015 RID: 57365 RVA: 0x00136D7C File Offset: 0x00134F7C
		public virtual double[] GetAxis()
		{
			IntPtr intPtr = vtkCellGridElevation.vtkCellGridElevation_GetAxis_02(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600E016 RID: 57366
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGridElevation_GetAxis_03(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E017 RID: 57367 RVA: 0x00136DC4 File Offset: 0x00134FC4
		public virtual void GetAxis(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkCellGridElevation.vtkCellGridElevation_GetAxis_03(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600E018 RID: 57368
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGridElevation_GetAxis_04(HandleRef pThis, IntPtr _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E019 RID: 57369 RVA: 0x00136DD6 File Offset: 0x00134FD6
		public virtual void GetAxis(IntPtr _arg)
		{
			vtkCellGridElevation.vtkCellGridElevation_GetAxis_04(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E01A RID: 57370
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellGridElevation_GetNumberOfAxes_05(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E01B RID: 57371 RVA: 0x00136DE8 File Offset: 0x00134FE8
		public virtual int GetNumberOfAxes()
		{
			return vtkCellGridElevation.vtkCellGridElevation_GetNumberOfAxes_05(base.GetCppThis());
		}

		// Token: 0x0600E01C RID: 57372
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellGridElevation_GetNumberOfAxesMaxValue_06(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E01D RID: 57373 RVA: 0x00136E08 File Offset: 0x00135008
		public virtual int GetNumberOfAxesMaxValue()
		{
			return vtkCellGridElevation.vtkCellGridElevation_GetNumberOfAxesMaxValue_06(base.GetCppThis());
		}

		// Token: 0x0600E01E RID: 57374
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellGridElevation_GetNumberOfAxesMinValue_07(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E01F RID: 57375 RVA: 0x00136E28 File Offset: 0x00135028
		public virtual int GetNumberOfAxesMinValue()
		{
			return vtkCellGridElevation.vtkCellGridElevation_GetNumberOfAxesMinValue_07(base.GetCppThis());
		}

		// Token: 0x0600E020 RID: 57376
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellGridElevation_GetNumberOfGenerationsFromBase_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E021 RID: 57377 RVA: 0x00136E48 File Offset: 0x00135048
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCellGridElevation.vtkCellGridElevation_GetNumberOfGenerationsFromBase_08(base.GetCppThis(), type);
		}

		// Token: 0x0600E022 RID: 57378
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCellGridElevation_GetNumberOfGenerationsFromBaseType_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E023 RID: 57379 RVA: 0x00136E68 File Offset: 0x00135068
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCellGridElevation.vtkCellGridElevation_GetNumberOfGenerationsFromBaseType_09(type);
		}

		// Token: 0x0600E024 RID: 57380
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridElevation_GetOrigin_10(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E025 RID: 57381 RVA: 0x00136E84 File Offset: 0x00135084
		public virtual double[] GetOrigin()
		{
			IntPtr intPtr = vtkCellGridElevation.vtkCellGridElevation_GetOrigin_10(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0600E026 RID: 57382
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGridElevation_GetOrigin_11(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E027 RID: 57383 RVA: 0x00136ECC File Offset: 0x001350CC
		public virtual void GetOrigin(ref double _arg1, ref double _arg2, ref double _arg3)
		{
			vtkCellGridElevation.vtkCellGridElevation_GetOrigin_11(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x0600E028 RID: 57384
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGridElevation_GetOrigin_12(HandleRef pThis, IntPtr _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E029 RID: 57385 RVA: 0x00136EDE File Offset: 0x001350DE
		public virtual void GetOrigin(IntPtr _arg)
		{
			vtkCellGridElevation.vtkCellGridElevation_GetOrigin_12(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E02A RID: 57386
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkCellGridElevation_GetShock_13(HandleRef pThis);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E02B RID: 57387 RVA: 0x00136EF0 File Offset: 0x001350F0
		public virtual double GetShock()
		{
			return vtkCellGridElevation.vtkCellGridElevation_GetShock_13(base.GetCppThis());
		}

		// Token: 0x0600E02C RID: 57388
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellGridElevation_IsA_14(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E02D RID: 57389 RVA: 0x00136F10 File Offset: 0x00135110
		public override int IsA(string type)
		{
			return vtkCellGridElevation.vtkCellGridElevation_IsA_14(base.GetCppThis(), type);
		}

		// Token: 0x0600E02E RID: 57390
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCellGridElevation_IsTypeOf_15([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E02F RID: 57391 RVA: 0x00136F30 File Offset: 0x00135130
		public new static int IsTypeOf(string type)
		{
			return vtkCellGridElevation.vtkCellGridElevation_IsTypeOf_15(type);
		}

		// Token: 0x0600E030 RID: 57392
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridElevation_NewInstance_17(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E031 RID: 57393 RVA: 0x00136F4C File Offset: 0x0013514C
		public new vtkCellGridElevation NewInstance()
		{
			vtkCellGridElevation result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridElevation.vtkCellGridElevation_NewInstance_17(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCellGridElevation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600E032 RID: 57394
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCellGridElevation_SafeDownCast_18(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E033 RID: 57395 RVA: 0x00136FA8 File Offset: 0x001351A8
		public new static vtkCellGridElevation SafeDownCast(vtkObjectBase o)
		{
			vtkCellGridElevation vtkCellGridElevation = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCellGridElevation.vtkCellGridElevation_SafeDownCast_18((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCellGridElevation = (vtkCellGridElevation)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCellGridElevation.Register(null);
				}
			}
			return vtkCellGridElevation;
		}

		// Token: 0x0600E034 RID: 57396
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGridElevation_SetAttributeName_19(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E035 RID: 57397 RVA: 0x00137027 File Offset: 0x00135227
		public virtual void SetAttributeName(string _arg)
		{
			vtkCellGridElevation.vtkCellGridElevation_SetAttributeName_19(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E036 RID: 57398
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGridElevation_SetAxis_20(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E037 RID: 57399 RVA: 0x00137037 File Offset: 0x00135237
		public virtual void SetAxis(double _arg1, double _arg2, double _arg3)
		{
			vtkCellGridElevation.vtkCellGridElevation_SetAxis_20(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600E038 RID: 57400
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGridElevation_SetAxis_21(HandleRef pThis, IntPtr _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E039 RID: 57401 RVA: 0x00137049 File Offset: 0x00135249
		public virtual void SetAxis(IntPtr _arg)
		{
			vtkCellGridElevation.vtkCellGridElevation_SetAxis_21(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E03A RID: 57402
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGridElevation_SetNumberOfAxes_22(HandleRef pThis, int _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E03B RID: 57403 RVA: 0x00137059 File Offset: 0x00135259
		public virtual void SetNumberOfAxes(int _arg)
		{
			vtkCellGridElevation.vtkCellGridElevation_SetNumberOfAxes_22(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E03C RID: 57404
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGridElevation_SetOrigin_23(HandleRef pThis, double _arg1, double _arg2, double _arg3);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E03D RID: 57405 RVA: 0x00137069 File Offset: 0x00135269
		public virtual void SetOrigin(double _arg1, double _arg2, double _arg3)
		{
			vtkCellGridElevation.vtkCellGridElevation_SetOrigin_23(base.GetCppThis(), _arg1, _arg2, _arg3);
		}

		// Token: 0x0600E03E RID: 57406
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGridElevation_SetOrigin_24(HandleRef pThis, IntPtr _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E03F RID: 57407 RVA: 0x0013707B File Offset: 0x0013527B
		public virtual void SetOrigin(IntPtr _arg)
		{
			vtkCellGridElevation.vtkCellGridElevation_SetOrigin_24(base.GetCppThis(), _arg);
		}

		// Token: 0x0600E040 RID: 57408
		[DllImport("Kitware.VTK.FiltersCellGrid.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCellGridElevation_SetShock_25(HandleRef pThis, double _arg);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600E041 RID: 57409 RVA: 0x0013708B File Offset: 0x0013528B
		public virtual void SetShock(double _arg)
		{
			vtkCellGridElevation.vtkCellGridElevation_SetShock_25(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001075 RID: 4213
		public new const string MRFullTypeName = "Kitware.VTK.vtkCellGridElevation";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001076 RID: 4214
		public new static readonly string MRClassNameKey = "class vtkCellGridElevation";
	}
}
