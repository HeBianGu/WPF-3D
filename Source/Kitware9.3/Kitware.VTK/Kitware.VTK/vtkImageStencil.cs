using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageStencil
	/// </summary>
	/// <remarks>
	///    combine images via a cookie-cutter operation
	///
	/// vtkImageStencil will combine two images together using a stencil.
	/// The stencil should be provided in the form of a vtkImageStencilData,
	/// </remarks>
	// Token: 0x02000234 RID: 564
	public class vtkImageStencil : vtkThreadedImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0600696F RID: 26991 RVA: 0x000985DE File Offset: 0x000967DE
		static vtkImageStencil()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageStencil.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageStencil"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06006970 RID: 26992 RVA: 0x00098606 File Offset: 0x00096806
		public vtkImageStencil(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06006971 RID: 26993
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageStencil_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006972 RID: 26994 RVA: 0x00098614 File Offset: 0x00096814
		public new static vtkImageStencil New()
		{
			vtkImageStencil result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageStencil.vtkImageStencil_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageStencil)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006973 RID: 26995 RVA: 0x00098668 File Offset: 0x00096868
		public vtkImageStencil() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageStencil.vtkImageStencil_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06006974 RID: 26996 RVA: 0x000986AC File Offset: 0x000968AC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06006975 RID: 26997
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageStencil_GetBackgroundColor_01(HandleRef pThis);

		/// <summary>
		/// Set the default color to use when the second input is not set.
		/// This is like SetBackgroundValue, but for multi-component images.
		/// </summary>
		// Token: 0x06006976 RID: 26998 RVA: 0x000986B8 File Offset: 0x000968B8
		public virtual double[] GetBackgroundColor()
		{
			IntPtr intPtr = vtkImageStencil.vtkImageStencil_GetBackgroundColor_01(base.GetCppThis());
			double[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new double[4];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06006977 RID: 26999
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStencil_GetBackgroundColor_02(HandleRef pThis, ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4);

		/// <summary>
		/// Set the default color to use when the second input is not set.
		/// This is like SetBackgroundValue, but for multi-component images.
		/// </summary>
		// Token: 0x06006978 RID: 27000 RVA: 0x00098700 File Offset: 0x00096900
		public virtual void GetBackgroundColor(ref double _arg1, ref double _arg2, ref double _arg3, ref double _arg4)
		{
			vtkImageStencil.vtkImageStencil_GetBackgroundColor_02(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3, ref _arg4);
		}

		// Token: 0x06006979 RID: 27001
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStencil_GetBackgroundColor_03(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the default color to use when the second input is not set.
		/// This is like SetBackgroundValue, but for multi-component images.
		/// </summary>
		// Token: 0x0600697A RID: 27002 RVA: 0x00098714 File Offset: 0x00096914
		public virtual void GetBackgroundColor(IntPtr _arg)
		{
			vtkImageStencil.vtkImageStencil_GetBackgroundColor_03(base.GetCppThis(), _arg);
		}

		// Token: 0x0600697B RID: 27003
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageStencil_GetBackgroundInput_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Set the second input.  This image will be used for the 'outside' of the
		/// stencil.  If not set, the output voxels will be filled with
		/// BackgroundValue instead.
		/// </summary>
		// Token: 0x0600697C RID: 27004 RVA: 0x00098724 File Offset: 0x00096924
		public vtkImageData GetBackgroundInput()
		{
			vtkImageData vtkImageData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageStencil.vtkImageStencil_GetBackgroundInput_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageData = (vtkImageData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageData.Register(null);
				}
			}
			return vtkImageData;
		}

		// Token: 0x0600697D RID: 27005
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageStencil_GetBackgroundValue_05(HandleRef pThis);

		/// <summary>
		/// Set the default output value to use when the second input is not set.
		/// </summary>
		// Token: 0x0600697E RID: 27006 RVA: 0x00098794 File Offset: 0x00096994
		public double GetBackgroundValue()
		{
			return vtkImageStencil.vtkImageStencil_GetBackgroundValue_05(base.GetCppThis());
		}

		// Token: 0x0600697F RID: 27007
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageStencil_GetNumberOfGenerationsFromBase_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006980 RID: 27008 RVA: 0x000987B4 File Offset: 0x000969B4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageStencil.vtkImageStencil_GetNumberOfGenerationsFromBase_06(base.GetCppThis(), type);
		}

		// Token: 0x06006981 RID: 27009
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageStencil_GetNumberOfGenerationsFromBaseType_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006982 RID: 27010 RVA: 0x000987D4 File Offset: 0x000969D4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageStencil.vtkImageStencil_GetNumberOfGenerationsFromBaseType_07(type);
		}

		// Token: 0x06006983 RID: 27011
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageStencil_GetReverseStencil_08(HandleRef pThis);

		/// <summary>
		/// Reverse the stencil.
		/// </summary>
		// Token: 0x06006984 RID: 27012 RVA: 0x000987F0 File Offset: 0x000969F0
		public virtual int GetReverseStencil()
		{
			return vtkImageStencil.vtkImageStencil_GetReverseStencil_08(base.GetCppThis());
		}

		// Token: 0x06006985 RID: 27013
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageStencil_GetStencil_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the stencil to use.  The stencil can be created
		/// from a vtkImplicitFunction or a vtkPolyData. This
		/// function does not setup a pipeline connection.
		/// </summary>
		// Token: 0x06006986 RID: 27014 RVA: 0x00098810 File Offset: 0x00096A10
		public vtkImageStencilData GetStencil()
		{
			vtkImageStencilData vtkImageStencilData = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageStencil.vtkImageStencil_GetStencil_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageStencilData = (vtkImageStencilData)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageStencilData.Register(null);
				}
			}
			return vtkImageStencilData;
		}

		// Token: 0x06006987 RID: 27015
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageStencil_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006988 RID: 27016 RVA: 0x00098880 File Offset: 0x00096A80
		public override int IsA(string type)
		{
			return vtkImageStencil.vtkImageStencil_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x06006989 RID: 27017
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageStencil_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600698A RID: 27018 RVA: 0x000988A0 File Offset: 0x00096AA0
		public new static int IsTypeOf(string type)
		{
			return vtkImageStencil.vtkImageStencil_IsTypeOf_11(type);
		}

		// Token: 0x0600698B RID: 27019
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageStencil_NewInstance_13(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600698C RID: 27020 RVA: 0x000988BC File Offset: 0x00096ABC
		public new vtkImageStencil NewInstance()
		{
			vtkImageStencil result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageStencil.vtkImageStencil_NewInstance_13(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageStencil)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0600698D RID: 27021
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStencil_ReverseStencilOff_14(HandleRef pThis);

		/// <summary>
		/// Reverse the stencil.
		/// </summary>
		// Token: 0x0600698E RID: 27022 RVA: 0x00098916 File Offset: 0x00096B16
		public virtual void ReverseStencilOff()
		{
			vtkImageStencil.vtkImageStencil_ReverseStencilOff_14(base.GetCppThis());
		}

		// Token: 0x0600698F RID: 27023
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStencil_ReverseStencilOn_15(HandleRef pThis);

		/// <summary>
		/// Reverse the stencil.
		/// </summary>
		// Token: 0x06006990 RID: 27024 RVA: 0x00098925 File Offset: 0x00096B25
		public virtual void ReverseStencilOn()
		{
			vtkImageStencil.vtkImageStencil_ReverseStencilOn_15(base.GetCppThis());
		}

		// Token: 0x06006991 RID: 27025
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageStencil_SafeDownCast_16(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006992 RID: 27026 RVA: 0x00098934 File Offset: 0x00096B34
		public new static vtkImageStencil SafeDownCast(vtkObjectBase o)
		{
			vtkImageStencil vtkImageStencil = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageStencil.vtkImageStencil_SafeDownCast_16((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageStencil = (vtkImageStencil)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageStencil.Register(null);
				}
			}
			return vtkImageStencil;
		}

		// Token: 0x06006993 RID: 27027
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStencil_SetBackgroundColor_17(HandleRef pThis, double _arg1, double _arg2, double _arg3, double _arg4);

		/// <summary>
		/// Set the default color to use when the second input is not set.
		/// This is like SetBackgroundValue, but for multi-component images.
		/// </summary>
		// Token: 0x06006994 RID: 27028 RVA: 0x000989B3 File Offset: 0x00096BB3
		public virtual void SetBackgroundColor(double _arg1, double _arg2, double _arg3, double _arg4)
		{
			vtkImageStencil.vtkImageStencil_SetBackgroundColor_17(base.GetCppThis(), _arg1, _arg2, _arg3, _arg4);
		}

		// Token: 0x06006995 RID: 27029
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStencil_SetBackgroundColor_18(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set the default color to use when the second input is not set.
		/// This is like SetBackgroundValue, but for multi-component images.
		/// </summary>
		// Token: 0x06006996 RID: 27030 RVA: 0x000989C7 File Offset: 0x00096BC7
		public virtual void SetBackgroundColor(IntPtr _arg)
		{
			vtkImageStencil.vtkImageStencil_SetBackgroundColor_18(base.GetCppThis(), _arg);
		}

		// Token: 0x06006997 RID: 27031
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStencil_SetBackgroundInputData_19(HandleRef pThis, HandleRef input);

		/// <summary>
		/// Set the second input.  This image will be used for the 'outside' of the
		/// stencil.  If not set, the output voxels will be filled with
		/// BackgroundValue instead.
		/// </summary>
		// Token: 0x06006998 RID: 27032 RVA: 0x000989D8 File Offset: 0x00096BD8
		public virtual void SetBackgroundInputData(vtkImageData input)
		{
			vtkImageStencil.vtkImageStencil_SetBackgroundInputData_19(base.GetCppThis(), (input == null) ? default(HandleRef) : input.GetCppThis());
		}

		// Token: 0x06006999 RID: 27033
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStencil_SetBackgroundValue_20(HandleRef pThis, double val);

		/// <summary>
		/// Set the default output value to use when the second input is not set.
		/// </summary>
		// Token: 0x0600699A RID: 27034 RVA: 0x00098A07 File Offset: 0x00096C07
		public void SetBackgroundValue(double val)
		{
			vtkImageStencil.vtkImageStencil_SetBackgroundValue_20(base.GetCppThis(), val);
		}

		// Token: 0x0600699B RID: 27035
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStencil_SetReverseStencil_21(HandleRef pThis, int _arg);

		/// <summary>
		/// Reverse the stencil.
		/// </summary>
		// Token: 0x0600699C RID: 27036 RVA: 0x00098A17 File Offset: 0x00096C17
		public virtual void SetReverseStencil(int _arg)
		{
			vtkImageStencil.vtkImageStencil_SetReverseStencil_21(base.GetCppThis(), _arg);
		}

		// Token: 0x0600699D RID: 27037
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStencil_SetStencilConnection_22(HandleRef pThis, HandleRef outputPort);

		/// <summary>
		/// Specify the stencil to use. This sets up a pipeline connection.
		/// </summary>
		// Token: 0x0600699E RID: 27038 RVA: 0x00098A28 File Offset: 0x00096C28
		public void SetStencilConnection(vtkAlgorithmOutput outputPort)
		{
			vtkImageStencil.vtkImageStencil_SetStencilConnection_22(base.GetCppThis(), (outputPort == null) ? default(HandleRef) : outputPort.GetCppThis());
		}

		// Token: 0x0600699F RID: 27039
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageStencil_SetStencilData_23(HandleRef pThis, HandleRef stencil);

		/// <summary>
		/// Specify the stencil to use.  The stencil can be created
		/// from a vtkImplicitFunction or a vtkPolyData. This
		/// function does not setup a pipeline connection.
		/// </summary>
		// Token: 0x060069A0 RID: 27040 RVA: 0x00098A58 File Offset: 0x00096C58
		public virtual void SetStencilData(vtkImageStencilData stencil)
		{
			vtkImageStencil.vtkImageStencil_SetStencilData_23(base.GetCppThis(), (stencil == null) ? default(HandleRef) : stencil.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000952 RID: 2386
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageStencil";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000953 RID: 2387
		public new static readonly string MRClassNameKey = "class vtkImageStencil";
	}
}
