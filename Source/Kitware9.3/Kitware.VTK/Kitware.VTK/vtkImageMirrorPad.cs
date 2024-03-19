using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageMirrorPad
	/// </summary>
	/// <remarks>
	///    Extra pixels are filled by mirror images.
	///
	/// vtkImageMirrorPad makes an image larger by filling extra pixels with
	/// a mirror image of the original image (mirror at image boundaries).
	/// </remarks>
	// Token: 0x0200085C RID: 2140
	public class vtkImageMirrorPad : vtkImagePadFilter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0601632C RID: 90924 RVA: 0x001F3EE7 File Offset: 0x001F20E7
		static vtkImageMirrorPad()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageMirrorPad.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageMirrorPad"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x0601632D RID: 90925 RVA: 0x001F3F0F File Offset: 0x001F210F
		public vtkImageMirrorPad(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601632E RID: 90926
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageMirrorPad_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601632F RID: 90927 RVA: 0x001F3F20 File Offset: 0x001F2120
		public new static vtkImageMirrorPad New()
		{
			vtkImageMirrorPad result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageMirrorPad.vtkImageMirrorPad_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageMirrorPad)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016330 RID: 90928 RVA: 0x001F3F74 File Offset: 0x001F2174
		public vtkImageMirrorPad() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageMirrorPad.vtkImageMirrorPad_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06016331 RID: 90929 RVA: 0x001F3FB8 File Offset: 0x001F21B8
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06016332 RID: 90930
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageMirrorPad_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016333 RID: 90931 RVA: 0x001F3FC4 File Offset: 0x001F21C4
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageMirrorPad.vtkImageMirrorPad_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06016334 RID: 90932
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageMirrorPad_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016335 RID: 90933 RVA: 0x001F3FE4 File Offset: 0x001F21E4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageMirrorPad.vtkImageMirrorPad_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x06016336 RID: 90934
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageMirrorPad_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016337 RID: 90935 RVA: 0x001F4000 File Offset: 0x001F2200
		public override int IsA(string type)
		{
			return vtkImageMirrorPad.vtkImageMirrorPad_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06016338 RID: 90936
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageMirrorPad_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016339 RID: 90937 RVA: 0x001F4020 File Offset: 0x001F2220
		public new static int IsTypeOf(string type)
		{
			return vtkImageMirrorPad.vtkImageMirrorPad_IsTypeOf_04(type);
		}

		// Token: 0x0601633A RID: 90938
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageMirrorPad_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601633B RID: 90939 RVA: 0x001F403C File Offset: 0x001F223C
		public new vtkImageMirrorPad NewInstance()
		{
			vtkImageMirrorPad result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageMirrorPad.vtkImageMirrorPad_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageMirrorPad)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x0601633C RID: 90940
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageMirrorPad_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601633D RID: 90941 RVA: 0x001F4098 File Offset: 0x001F2298
		public new static vtkImageMirrorPad SafeDownCast(vtkObjectBase o)
		{
			vtkImageMirrorPad vtkImageMirrorPad = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageMirrorPad.vtkImageMirrorPad_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageMirrorPad = (vtkImageMirrorPad)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageMirrorPad.Register(null);
				}
			}
			return vtkImageMirrorPad;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400190C RID: 6412
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageMirrorPad";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400190D RID: 6413
		public new static readonly string MRClassNameKey = "class vtkImageMirrorPad";
	}
}
