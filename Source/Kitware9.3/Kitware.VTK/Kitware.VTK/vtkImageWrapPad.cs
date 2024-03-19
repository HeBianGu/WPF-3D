using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageWrapPad
	/// </summary>
	/// <remarks>
	///    Makes an image larger by wrapping existing data.
	///
	/// vtkImageWrapPad performs a modulo operation on the output pixel index
	/// to determine the source input index.  The new image extent of the
	/// output has to be specified.  Input has to be the same scalar type as
	/// output.
	/// </remarks>
	// Token: 0x0200086B RID: 2155
	public class vtkImageWrapPad : vtkImagePadFilter
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06016604 RID: 91652 RVA: 0x001F7555 File Offset: 0x001F5755
		static vtkImageWrapPad()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageWrapPad.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageWrapPad"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06016605 RID: 91653 RVA: 0x001F757D File Offset: 0x001F577D
		public vtkImageWrapPad(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06016606 RID: 91654
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageWrapPad_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016607 RID: 91655 RVA: 0x001F758C File Offset: 0x001F578C
		public new static vtkImageWrapPad New()
		{
			vtkImageWrapPad result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageWrapPad.vtkImageWrapPad_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageWrapPad)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016608 RID: 91656 RVA: 0x001F75E0 File Offset: 0x001F57E0
		public vtkImageWrapPad() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageWrapPad.vtkImageWrapPad_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06016609 RID: 91657 RVA: 0x001F7624 File Offset: 0x001F5824
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601660A RID: 91658
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageWrapPad_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601660B RID: 91659 RVA: 0x001F7630 File Offset: 0x001F5830
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageWrapPad.vtkImageWrapPad_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x0601660C RID: 91660
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageWrapPad_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601660D RID: 91661 RVA: 0x001F7650 File Offset: 0x001F5850
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageWrapPad.vtkImageWrapPad_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601660E RID: 91662
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageWrapPad_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601660F RID: 91663 RVA: 0x001F766C File Offset: 0x001F586C
		public override int IsA(string type)
		{
			return vtkImageWrapPad.vtkImageWrapPad_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x06016610 RID: 91664
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageWrapPad_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016611 RID: 91665 RVA: 0x001F768C File Offset: 0x001F588C
		public new static int IsTypeOf(string type)
		{
			return vtkImageWrapPad.vtkImageWrapPad_IsTypeOf_04(type);
		}

		// Token: 0x06016612 RID: 91666
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageWrapPad_NewInstance_06(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016613 RID: 91667 RVA: 0x001F76A8 File Offset: 0x001F58A8
		public new vtkImageWrapPad NewInstance()
		{
			vtkImageWrapPad result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageWrapPad.vtkImageWrapPad_NewInstance_06(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageWrapPad)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06016614 RID: 91668
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageWrapPad_SafeDownCast_07(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016615 RID: 91669 RVA: 0x001F7704 File Offset: 0x001F5904
		public new static vtkImageWrapPad SafeDownCast(vtkObjectBase o)
		{
			vtkImageWrapPad vtkImageWrapPad = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageWrapPad.vtkImageWrapPad_SafeDownCast_07((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageWrapPad = (vtkImageWrapPad)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageWrapPad.Register(null);
				}
			}
			return vtkImageWrapPad;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400192C RID: 6444
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageWrapPad";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400192D RID: 6445
		public new static readonly string MRClassNameKey = "class vtkImageWrapPad";
	}
}
