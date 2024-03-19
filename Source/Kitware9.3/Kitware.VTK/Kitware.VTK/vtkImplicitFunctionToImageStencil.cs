using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImplicitFunctionToImageStencil
	/// </summary>
	/// <remarks>
	///    clip an image with a function
	///
	/// vtkImplicitFunctionToImageStencil will convert a vtkImplicitFunction into
	/// a stencil that can be used with vtkImageStencil or with other classes
	/// that apply a stencil to an image.
	/// </remarks>
	/// <seealso>
	///
	/// vtkImplicitFunction vtkImageStencil vtkPolyDataToImageStencil
	/// </seealso>
	// Token: 0x02000239 RID: 569
	public class vtkImplicitFunctionToImageStencil : vtkImageStencilSource
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06006A43 RID: 27203 RVA: 0x000998BF File Offset: 0x00097ABF
		static vtkImplicitFunctionToImageStencil()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImplicitFunctionToImageStencil.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImplicitFunctionToImageStencil"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06006A44 RID: 27204 RVA: 0x000998E7 File Offset: 0x00097AE7
		public vtkImplicitFunctionToImageStencil(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06006A45 RID: 27205
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitFunctionToImageStencil_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006A46 RID: 27206 RVA: 0x000998F8 File Offset: 0x00097AF8
		public new static vtkImplicitFunctionToImageStencil New()
		{
			vtkImplicitFunctionToImageStencil result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitFunctionToImageStencil.vtkImplicitFunctionToImageStencil_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitFunctionToImageStencil)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006A47 RID: 27207 RVA: 0x0009994C File Offset: 0x00097B4C
		public vtkImplicitFunctionToImageStencil() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImplicitFunctionToImageStencil.vtkImplicitFunctionToImageStencil_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06006A48 RID: 27208 RVA: 0x00099990 File Offset: 0x00097B90
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06006A49 RID: 27209
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitFunctionToImageStencil_GetInput_01(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Specify the implicit function to convert into a stencil.
		/// </summary>
		// Token: 0x06006A4A RID: 27210 RVA: 0x0009999C File Offset: 0x00097B9C
		public virtual vtkImplicitFunction GetInput()
		{
			vtkImplicitFunction vtkImplicitFunction = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitFunctionToImageStencil.vtkImplicitFunctionToImageStencil_GetInput_01(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06006A4B RID: 27211
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkImplicitFunctionToImageStencil_GetMTime_02(HandleRef pThis);

		/// <summary>
		/// Override GetMTime() to account for the implicit function.
		/// </summary>
		// Token: 0x06006A4C RID: 27212 RVA: 0x00099A0C File Offset: 0x00097C0C
		public override ulong GetMTime()
		{
			return vtkImplicitFunctionToImageStencil.vtkImplicitFunctionToImageStencil_GetMTime_02(base.GetCppThis());
		}

		// Token: 0x06006A4D RID: 27213
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImplicitFunctionToImageStencil_GetNumberOfGenerationsFromBase_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006A4E RID: 27214 RVA: 0x00099A2C File Offset: 0x00097C2C
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImplicitFunctionToImageStencil.vtkImplicitFunctionToImageStencil_GetNumberOfGenerationsFromBase_03(base.GetCppThis(), type);
		}

		// Token: 0x06006A4F RID: 27215
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImplicitFunctionToImageStencil_GetNumberOfGenerationsFromBaseType_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006A50 RID: 27216 RVA: 0x00099A4C File Offset: 0x00097C4C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImplicitFunctionToImageStencil.vtkImplicitFunctionToImageStencil_GetNumberOfGenerationsFromBaseType_04(type);
		}

		// Token: 0x06006A51 RID: 27217
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImplicitFunctionToImageStencil_GetThreshold_05(HandleRef pThis);

		/// <summary>
		/// Set the threshold value for the implicit function.
		/// </summary>
		// Token: 0x06006A52 RID: 27218 RVA: 0x00099A68 File Offset: 0x00097C68
		public virtual double GetThreshold()
		{
			return vtkImplicitFunctionToImageStencil.vtkImplicitFunctionToImageStencil_GetThreshold_05(base.GetCppThis());
		}

		// Token: 0x06006A53 RID: 27219
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitFunctionToImageStencil_IsA_06(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006A54 RID: 27220 RVA: 0x00099A88 File Offset: 0x00097C88
		public override int IsA(string type)
		{
			return vtkImplicitFunctionToImageStencil.vtkImplicitFunctionToImageStencil_IsA_06(base.GetCppThis(), type);
		}

		// Token: 0x06006A55 RID: 27221
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImplicitFunctionToImageStencil_IsTypeOf_07([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006A56 RID: 27222 RVA: 0x00099AA8 File Offset: 0x00097CA8
		public new static int IsTypeOf(string type)
		{
			return vtkImplicitFunctionToImageStencil.vtkImplicitFunctionToImageStencil_IsTypeOf_07(type);
		}

		// Token: 0x06006A57 RID: 27223
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitFunctionToImageStencil_NewInstance_09(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006A58 RID: 27224 RVA: 0x00099AC4 File Offset: 0x00097CC4
		public new vtkImplicitFunctionToImageStencil NewInstance()
		{
			vtkImplicitFunctionToImageStencil result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitFunctionToImageStencil.vtkImplicitFunctionToImageStencil_NewInstance_09(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImplicitFunctionToImageStencil)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06006A59 RID: 27225
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImplicitFunctionToImageStencil_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06006A5A RID: 27226 RVA: 0x00099B20 File Offset: 0x00097D20
		public new static vtkImplicitFunctionToImageStencil SafeDownCast(vtkObjectBase o)
		{
			vtkImplicitFunctionToImageStencil vtkImplicitFunctionToImageStencil = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImplicitFunctionToImageStencil.vtkImplicitFunctionToImageStencil_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImplicitFunctionToImageStencil = (vtkImplicitFunctionToImageStencil)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImplicitFunctionToImageStencil.Register(null);
				}
			}
			return vtkImplicitFunctionToImageStencil;
		}

		// Token: 0x06006A5B RID: 27227
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitFunctionToImageStencil_SetInput_11(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Specify the implicit function to convert into a stencil.
		/// </summary>
		// Token: 0x06006A5C RID: 27228 RVA: 0x00099BA0 File Offset: 0x00097DA0
		public virtual void SetInput(vtkImplicitFunction arg0)
		{
			vtkImplicitFunctionToImageStencil.vtkImplicitFunctionToImageStencil_SetInput_11(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06006A5D RID: 27229
		[DllImport("Kitware.VTK.ImagingStencil.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImplicitFunctionToImageStencil_SetThreshold_12(HandleRef pThis, double _arg);

		/// <summary>
		/// Set the threshold value for the implicit function.
		/// </summary>
		// Token: 0x06006A5E RID: 27230 RVA: 0x00099BCF File Offset: 0x00097DCF
		public virtual void SetThreshold(double _arg)
		{
			vtkImplicitFunctionToImageStencil.vtkImplicitFunctionToImageStencil_SetThreshold_12(base.GetCppThis(), _arg);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400095C RID: 2396
		public new const string MRFullTypeName = "Kitware.VTK.vtkImplicitFunctionToImageStencil";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400095D RID: 2397
		public new static readonly string MRClassNameKey = "class vtkImplicitFunctionToImageStencil";
	}
}
