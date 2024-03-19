using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkHedgeHog
	/// </summary>
	/// <remarks>
	///    create oriented lines from vector data
	///
	/// vtkHedgeHog creates oriented lines from the input data set. Line
	/// length is controlled by vector (or normal) magnitude times scale
	/// factor. If VectorMode is UseNormal, normals determine the orientation
	/// of the lines. Lines are colored by scalar data, if available.
	/// </remarks>
	// Token: 0x0200096F RID: 2415
	public class vtkHedgeHog : vtkPolyDataAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060192F2 RID: 103154 RVA: 0x002315DC File Offset: 0x0022F7DC
		static vtkHedgeHog()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkHedgeHog.MRClassNameKey, Type.GetType("Kitware.VTK.vtkHedgeHog"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060192F3 RID: 103155 RVA: 0x00231604 File Offset: 0x0022F804
		public vtkHedgeHog(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060192F4 RID: 103156
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHedgeHog_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060192F5 RID: 103157 RVA: 0x00231614 File Offset: 0x0022F814
		public new static vtkHedgeHog New()
		{
			vtkHedgeHog result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHedgeHog.vtkHedgeHog_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHedgeHog)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060192F6 RID: 103158 RVA: 0x00231668 File Offset: 0x0022F868
		public vtkHedgeHog() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkHedgeHog.vtkHedgeHog_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060192F7 RID: 103159 RVA: 0x002316AC File Offset: 0x0022F8AC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060192F8 RID: 103160
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHedgeHog_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060192F9 RID: 103161 RVA: 0x002316B8 File Offset: 0x0022F8B8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkHedgeHog.vtkHedgeHog_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x060192FA RID: 103162
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkHedgeHog_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060192FB RID: 103163 RVA: 0x002316D8 File Offset: 0x0022F8D8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkHedgeHog.vtkHedgeHog_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x060192FC RID: 103164
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHedgeHog_GetOutputPointsPrecision_03(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x060192FD RID: 103165 RVA: 0x002316F4 File Offset: 0x0022F8F4
		public virtual int GetOutputPointsPrecision()
		{
			return vtkHedgeHog.vtkHedgeHog_GetOutputPointsPrecision_03(base.GetCppThis());
		}

		// Token: 0x060192FE RID: 103166
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkHedgeHog_GetScaleFactor_04(HandleRef pThis);

		/// <summary>
		/// Set scale factor to control size of oriented lines.
		/// </summary>
		// Token: 0x060192FF RID: 103167 RVA: 0x00231714 File Offset: 0x0022F914
		public virtual double GetScaleFactor()
		{
			return vtkHedgeHog.vtkHedgeHog_GetScaleFactor_04(base.GetCppThis());
		}

		// Token: 0x06019300 RID: 103168
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHedgeHog_GetVectorMode_05(HandleRef pThis);

		/// <summary>
		/// Specify whether to use vector or normal to perform vector operations.
		/// </summary>
		// Token: 0x06019301 RID: 103169 RVA: 0x00231734 File Offset: 0x0022F934
		public virtual int GetVectorMode()
		{
			return vtkHedgeHog.vtkHedgeHog_GetVectorMode_05(base.GetCppThis());
		}

		// Token: 0x06019302 RID: 103170
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHedgeHog_GetVectorModeAsString_06(HandleRef pThis);

		/// <summary>
		/// Specify whether to use vector or normal to perform vector operations.
		/// </summary>
		// Token: 0x06019303 RID: 103171 RVA: 0x00231754 File Offset: 0x0022F954
		public string GetVectorModeAsString()
		{
			string s = Marshal.PtrToStringAnsi(vtkHedgeHog.vtkHedgeHog_GetVectorModeAsString_06(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06019304 RID: 103172
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHedgeHog_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019305 RID: 103173 RVA: 0x00231790 File Offset: 0x0022F990
		public override int IsA(string type)
		{
			return vtkHedgeHog.vtkHedgeHog_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x06019306 RID: 103174
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkHedgeHog_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019307 RID: 103175 RVA: 0x002317B0 File Offset: 0x0022F9B0
		public new static int IsTypeOf(string type)
		{
			return vtkHedgeHog.vtkHedgeHog_IsTypeOf_08(type);
		}

		// Token: 0x06019308 RID: 103176
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHedgeHog_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019309 RID: 103177 RVA: 0x002317CC File Offset: 0x0022F9CC
		public new vtkHedgeHog NewInstance()
		{
			vtkHedgeHog result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHedgeHog.vtkHedgeHog_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkHedgeHog)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601930A RID: 103178
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkHedgeHog_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601930B RID: 103179 RVA: 0x00231828 File Offset: 0x0022FA28
		public new static vtkHedgeHog SafeDownCast(vtkObjectBase o)
		{
			vtkHedgeHog vtkHedgeHog = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkHedgeHog.vtkHedgeHog_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkHedgeHog = (vtkHedgeHog)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkHedgeHog.Register(null);
				}
			}
			return vtkHedgeHog;
		}

		// Token: 0x0601930C RID: 103180
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHedgeHog_SetOutputPointsPrecision_12(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x0601930D RID: 103181 RVA: 0x002318A7 File Offset: 0x0022FAA7
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkHedgeHog.vtkHedgeHog_SetOutputPointsPrecision_12(base.GetCppThis(), _arg);
		}

		// Token: 0x0601930E RID: 103182
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHedgeHog_SetScaleFactor_13(HandleRef pThis, double _arg);

		/// <summary>
		/// Set scale factor to control size of oriented lines.
		/// </summary>
		// Token: 0x0601930F RID: 103183 RVA: 0x002318B7 File Offset: 0x0022FAB7
		public virtual void SetScaleFactor(double _arg)
		{
			vtkHedgeHog.vtkHedgeHog_SetScaleFactor_13(base.GetCppThis(), _arg);
		}

		// Token: 0x06019310 RID: 103184
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHedgeHog_SetVectorMode_14(HandleRef pThis, int _arg);

		/// <summary>
		/// Specify whether to use vector or normal to perform vector operations.
		/// </summary>
		// Token: 0x06019311 RID: 103185 RVA: 0x002318C7 File Offset: 0x0022FAC7
		public virtual void SetVectorMode(int _arg)
		{
			vtkHedgeHog.vtkHedgeHog_SetVectorMode_14(base.GetCppThis(), _arg);
		}

		// Token: 0x06019312 RID: 103186
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHedgeHog_SetVectorModeToUseNormal_15(HandleRef pThis);

		/// <summary>
		/// Specify whether to use vector or normal to perform vector operations.
		/// </summary>
		// Token: 0x06019313 RID: 103187 RVA: 0x002318D7 File Offset: 0x0022FAD7
		public void SetVectorModeToUseNormal()
		{
			vtkHedgeHog.vtkHedgeHog_SetVectorModeToUseNormal_15(base.GetCppThis());
		}

		// Token: 0x06019314 RID: 103188
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkHedgeHog_SetVectorModeToUseVector_16(HandleRef pThis);

		/// <summary>
		/// Specify whether to use vector or normal to perform vector operations.
		/// </summary>
		// Token: 0x06019315 RID: 103189 RVA: 0x002318E6 File Offset: 0x0022FAE6
		public void SetVectorModeToUseVector()
		{
			vtkHedgeHog.vtkHedgeHog_SetVectorModeToUseVector_16(base.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B97 RID: 7063
		public new const string MRFullTypeName = "Kitware.VTK.vtkHedgeHog";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001B98 RID: 7064
		public new static readonly string MRClassNameKey = "class vtkHedgeHog";
	}
}
