using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkSynchronizedTemplatesCutter3D
	/// </summary>
	/// <remarks>
	///    generate cut surface from structured points
	///
	///
	/// vtkSynchronizedTemplatesCutter3D is an implementation of the synchronized
	/// template algorithm. Note that vtkCutFilter will automatically
	/// use this class when appropriate.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkContourFilter vtkSynchronizedTemplates3D
	/// </seealso>
	// Token: 0x020009B1 RID: 2481
	public class vtkSynchronizedTemplatesCutter3D : vtkSynchronizedTemplates3D
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06019EB9 RID: 106169 RVA: 0x0023F5A8 File Offset: 0x0023D7A8
		static vtkSynchronizedTemplatesCutter3D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkSynchronizedTemplatesCutter3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkSynchronizedTemplatesCutter3D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06019EBA RID: 106170 RVA: 0x0023F5D0 File Offset: 0x0023D7D0
		public vtkSynchronizedTemplatesCutter3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06019EBB RID: 106171
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSynchronizedTemplatesCutter3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019EBC RID: 106172 RVA: 0x0023F5E0 File Offset: 0x0023D7E0
		public new static vtkSynchronizedTemplatesCutter3D New()
		{
			vtkSynchronizedTemplatesCutter3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSynchronizedTemplatesCutter3D.vtkSynchronizedTemplatesCutter3D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSynchronizedTemplatesCutter3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019EBD RID: 106173 RVA: 0x0023F634 File Offset: 0x0023D834
		public vtkSynchronizedTemplatesCutter3D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkSynchronizedTemplatesCutter3D.vtkSynchronizedTemplatesCutter3D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06019EBE RID: 106174 RVA: 0x0023F678 File Offset: 0x0023D878
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06019EBF RID: 106175
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSynchronizedTemplatesCutter3D_GetCutFunction_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the implicit function to perform the cutting.
		/// </summary>
		// Token: 0x06019EC0 RID: 106176 RVA: 0x0023F684 File Offset: 0x0023D884
		public virtual vtkImplicitFunction GetCutFunction()
		{
			vtkImplicitFunction vtkImplicitFunction = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSynchronizedTemplatesCutter3D.vtkSynchronizedTemplatesCutter3D_GetCutFunction_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImplicitFunction = (vtkImplicitFunction)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImplicitFunction.Register(null);
				}
			}
			return vtkImplicitFunction;
		}

		// Token: 0x06019EC1 RID: 106177
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSynchronizedTemplatesCutter3D_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019EC2 RID: 106178 RVA: 0x0023F6F4 File Offset: 0x0023D8F4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkSynchronizedTemplatesCutter3D.vtkSynchronizedTemplatesCutter3D_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06019EC3 RID: 106179
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkSynchronizedTemplatesCutter3D_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019EC4 RID: 106180 RVA: 0x0023F714 File Offset: 0x0023D914
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkSynchronizedTemplatesCutter3D.vtkSynchronizedTemplatesCutter3D_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06019EC5 RID: 106181
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSynchronizedTemplatesCutter3D_GetOutputPointsPrecision_04(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x06019EC6 RID: 106182 RVA: 0x0023F730 File Offset: 0x0023D930
		public virtual int GetOutputPointsPrecision()
		{
			return vtkSynchronizedTemplatesCutter3D.vtkSynchronizedTemplatesCutter3D_GetOutputPointsPrecision_04(base.GetCppThis());
		}

		// Token: 0x06019EC7 RID: 106183
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSynchronizedTemplatesCutter3D_GetOutputPointsPrecisionMaxValue_05(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x06019EC8 RID: 106184 RVA: 0x0023F750 File Offset: 0x0023D950
		public virtual int GetOutputPointsPrecisionMaxValue()
		{
			return vtkSynchronizedTemplatesCutter3D.vtkSynchronizedTemplatesCutter3D_GetOutputPointsPrecisionMaxValue_05(base.GetCppThis());
		}

		// Token: 0x06019EC9 RID: 106185
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSynchronizedTemplatesCutter3D_GetOutputPointsPrecisionMinValue_06(HandleRef pThis);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x06019ECA RID: 106186 RVA: 0x0023F770 File Offset: 0x0023D970
		public virtual int GetOutputPointsPrecisionMinValue()
		{
			return vtkSynchronizedTemplatesCutter3D.vtkSynchronizedTemplatesCutter3D_GetOutputPointsPrecisionMinValue_06(base.GetCppThis());
		}

		// Token: 0x06019ECB RID: 106187
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSynchronizedTemplatesCutter3D_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019ECC RID: 106188 RVA: 0x0023F790 File Offset: 0x0023D990
		public override int IsA(string type)
		{
			return vtkSynchronizedTemplatesCutter3D.vtkSynchronizedTemplatesCutter3D_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x06019ECD RID: 106189
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkSynchronizedTemplatesCutter3D_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019ECE RID: 106190 RVA: 0x0023F7B0 File Offset: 0x0023D9B0
		public new static int IsTypeOf(string type)
		{
			return vtkSynchronizedTemplatesCutter3D.vtkSynchronizedTemplatesCutter3D_IsTypeOf_08(type);
		}

		// Token: 0x06019ECF RID: 106191
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSynchronizedTemplatesCutter3D_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019ED0 RID: 106192 RVA: 0x0023F7CC File Offset: 0x0023D9CC
		public new vtkSynchronizedTemplatesCutter3D NewInstance()
		{
			vtkSynchronizedTemplatesCutter3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSynchronizedTemplatesCutter3D.vtkSynchronizedTemplatesCutter3D_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkSynchronizedTemplatesCutter3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06019ED1 RID: 106193
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkSynchronizedTemplatesCutter3D_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06019ED2 RID: 106194 RVA: 0x0023F828 File Offset: 0x0023DA28
		public new static vtkSynchronizedTemplatesCutter3D SafeDownCast(vtkObjectBase o)
		{
			vtkSynchronizedTemplatesCutter3D vtkSynchronizedTemplatesCutter3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkSynchronizedTemplatesCutter3D.vtkSynchronizedTemplatesCutter3D_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkSynchronizedTemplatesCutter3D = (vtkSynchronizedTemplatesCutter3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkSynchronizedTemplatesCutter3D.Register(null);
				}
			}
			return vtkSynchronizedTemplatesCutter3D;
		}

		// Token: 0x06019ED3 RID: 106195
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSynchronizedTemplatesCutter3D_SetCutFunction_12(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify the implicit function to perform the cutting.
		/// </summary>
		// Token: 0x06019ED4 RID: 106196 RVA: 0x0023F8A8 File Offset: 0x0023DAA8
		public virtual void SetCutFunction(vtkImplicitFunction arg0)
		{
			vtkSynchronizedTemplatesCutter3D.vtkSynchronizedTemplatesCutter3D_SetCutFunction_12(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06019ED5 RID: 106197
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSynchronizedTemplatesCutter3D_SetOutputPointsPrecision_13(HandleRef pThis, int _arg);

		/// <summary>
		/// Set/get the desired precision for the output types. See the documentation
		/// for the vtkAlgorithm::DesiredOutputPrecision enum for an explanation of
		/// the available precision settings.
		/// </summary>
		// Token: 0x06019ED6 RID: 106198 RVA: 0x0023F8D7 File Offset: 0x0023DAD7
		public virtual void SetOutputPointsPrecision(int _arg)
		{
			vtkSynchronizedTemplatesCutter3D.vtkSynchronizedTemplatesCutter3D_SetOutputPointsPrecision_13(base.GetCppThis(), _arg);
		}

		// Token: 0x06019ED7 RID: 106199
		[DllImport("Kitware.VTK.FiltersCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkSynchronizedTemplatesCutter3D_ThreadedExecute_14(HandleRef pThis, HandleRef data, HandleRef outInfo, int arg2);

		/// <summary>
		/// Needed by templated functions.
		/// </summary>
		// Token: 0x06019ED8 RID: 106200 RVA: 0x0023F8E8 File Offset: 0x0023DAE8
		public void ThreadedExecute(vtkImageData data, vtkInformation outInfo, int arg2)
		{
			vtkSynchronizedTemplatesCutter3D.vtkSynchronizedTemplatesCutter3D_ThreadedExecute_14(base.GetCppThis(), (data == null) ? default(HandleRef) : data.GetCppThis(), (outInfo == null) ? default(HandleRef) : outInfo.GetCppThis(), arg2);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C25 RID: 7205
		public new const string MRFullTypeName = "Kitware.VTK.vtkSynchronizedTemplatesCutter3D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001C26 RID: 7206
		public new static readonly string MRClassNameKey = "class vtkSynchronizedTemplatesCutter3D";
	}
}
