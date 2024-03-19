using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageClip
	/// </summary>
	/// <remarks>
	///    Reduces the image extent of the input.
	///
	/// vtkImageClip  will make an image smaller.  The output must have
	/// an image extent which is the subset of the input.  The filter has two
	/// modes of operation:
	/// 1: By default, the data is not copied in this filter.
	/// Only the whole extent is modified.
	/// 2: If ClipDataOn is set, then you will get no more that the clipped
	/// extent.
	/// </remarks>
	// Token: 0x02000854 RID: 2132
	public class vtkImageClip : vtkImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060161F8 RID: 90616 RVA: 0x001F24AB File Offset: 0x001F06AB
		static vtkImageClip()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageClip.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageClip"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060161F9 RID: 90617 RVA: 0x001F24D3 File Offset: 0x001F06D3
		public vtkImageClip(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060161FA RID: 90618
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageClip_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060161FB RID: 90619 RVA: 0x001F24E4 File Offset: 0x001F06E4
		public new static vtkImageClip New()
		{
			vtkImageClip result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageClip.vtkImageClip_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageClip)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060161FC RID: 90620 RVA: 0x001F2538 File Offset: 0x001F0738
		public vtkImageClip() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageClip.vtkImageClip_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060161FD RID: 90621 RVA: 0x001F257C File Offset: 0x001F077C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060161FE RID: 90622
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageClip_ClipDataOff_01(HandleRef pThis);

		/// <summary>
		/// By default, ClipData is off, and only the WholeExtent is modified.
		/// the data's extent may actually be larger.  When this flag is on,
		/// the data extent will be no more than the OutputWholeExtent.
		/// </summary>
		// Token: 0x060161FF RID: 90623 RVA: 0x001F2587 File Offset: 0x001F0787
		public virtual void ClipDataOff()
		{
			vtkImageClip.vtkImageClip_ClipDataOff_01(base.GetCppThis());
		}

		// Token: 0x06016200 RID: 90624
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageClip_ClipDataOn_02(HandleRef pThis);

		/// <summary>
		/// By default, ClipData is off, and only the WholeExtent is modified.
		/// the data's extent may actually be larger.  When this flag is on,
		/// the data extent will be no more than the OutputWholeExtent.
		/// </summary>
		// Token: 0x06016201 RID: 90625 RVA: 0x001F2596 File Offset: 0x001F0796
		public virtual void ClipDataOn()
		{
			vtkImageClip.vtkImageClip_ClipDataOn_02(base.GetCppThis());
		}

		// Token: 0x06016202 RID: 90626
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageClip_GetClipData_03(HandleRef pThis);

		/// <summary>
		/// By default, ClipData is off, and only the WholeExtent is modified.
		/// the data's extent may actually be larger.  When this flag is on,
		/// the data extent will be no more than the OutputWholeExtent.
		/// </summary>
		// Token: 0x06016203 RID: 90627 RVA: 0x001F25A8 File Offset: 0x001F07A8
		public virtual int GetClipData()
		{
			return vtkImageClip.vtkImageClip_GetClipData_03(base.GetCppThis());
		}

		// Token: 0x06016204 RID: 90628
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageClip_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016205 RID: 90629 RVA: 0x001F25C8 File Offset: 0x001F07C8
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageClip.vtkImageClip_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06016206 RID: 90630
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageClip_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016207 RID: 90631 RVA: 0x001F25E8 File Offset: 0x001F07E8
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageClip.vtkImageClip_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06016208 RID: 90632
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageClip_GetOutputWholeExtent_06(HandleRef pThis, IntPtr extent);

		/// <summary>
		/// The whole extent of the output has to be set explicitly.
		/// </summary>
		// Token: 0x06016209 RID: 90633 RVA: 0x001F2602 File Offset: 0x001F0802
		public void GetOutputWholeExtent(IntPtr extent)
		{
			vtkImageClip.vtkImageClip_GetOutputWholeExtent_06(base.GetCppThis(), extent);
		}

		// Token: 0x0601620A RID: 90634
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageClip_GetOutputWholeExtent_07(HandleRef pThis);

		/// <summary>
		/// The whole extent of the output has to be set explicitly.
		/// </summary>
		// Token: 0x0601620B RID: 90635 RVA: 0x001F2614 File Offset: 0x001F0814
		public int[] GetOutputWholeExtent()
		{
			IntPtr intPtr = vtkImageClip.vtkImageClip_GetOutputWholeExtent_07(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[6];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x0601620C RID: 90636
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageClip_IsA_08(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601620D RID: 90637 RVA: 0x001F265C File Offset: 0x001F085C
		public override int IsA(string type)
		{
			return vtkImageClip.vtkImageClip_IsA_08(base.GetCppThis(), type);
		}

		// Token: 0x0601620E RID: 90638
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageClip_IsTypeOf_09([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601620F RID: 90639 RVA: 0x001F267C File Offset: 0x001F087C
		public new static int IsTypeOf(string type)
		{
			return vtkImageClip.vtkImageClip_IsTypeOf_09(type);
		}

		// Token: 0x06016210 RID: 90640
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageClip_NewInstance_11(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016211 RID: 90641 RVA: 0x001F2698 File Offset: 0x001F0898
		public new vtkImageClip NewInstance()
		{
			vtkImageClip result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageClip.vtkImageClip_NewInstance_11(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageClip)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06016212 RID: 90642
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageClip_ResetOutputWholeExtent_12(HandleRef pThis);

		/// <summary>
		/// The whole extent of the output has to be set explicitly.
		/// </summary>
		// Token: 0x06016213 RID: 90643 RVA: 0x001F26F2 File Offset: 0x001F08F2
		public void ResetOutputWholeExtent()
		{
			vtkImageClip.vtkImageClip_ResetOutputWholeExtent_12(base.GetCppThis());
		}

		// Token: 0x06016214 RID: 90644
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageClip_SafeDownCast_13(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016215 RID: 90645 RVA: 0x001F2704 File Offset: 0x001F0904
		public new static vtkImageClip SafeDownCast(vtkObjectBase o)
		{
			vtkImageClip vtkImageClip = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageClip.vtkImageClip_SafeDownCast_13((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageClip = (vtkImageClip)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageClip.Register(null);
				}
			}
			return vtkImageClip;
		}

		// Token: 0x06016216 RID: 90646
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageClip_SetClipData_14(HandleRef pThis, int _arg);

		/// <summary>
		/// By default, ClipData is off, and only the WholeExtent is modified.
		/// the data's extent may actually be larger.  When this flag is on,
		/// the data extent will be no more than the OutputWholeExtent.
		/// </summary>
		// Token: 0x06016217 RID: 90647 RVA: 0x001F2783 File Offset: 0x001F0983
		public virtual void SetClipData(int _arg)
		{
			vtkImageClip.vtkImageClip_SetClipData_14(base.GetCppThis(), _arg);
		}

		// Token: 0x06016218 RID: 90648
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageClip_SetOutputWholeExtent_15(HandleRef pThis, IntPtr extent, HandleRef outInfo);

		/// <summary>
		/// The whole extent of the output has to be set explicitly.
		/// </summary>
		// Token: 0x06016219 RID: 90649 RVA: 0x001F2794 File Offset: 0x001F0994
		public void SetOutputWholeExtent(IntPtr extent, vtkInformation outInfo)
		{
			vtkImageClip.vtkImageClip_SetOutputWholeExtent_15(base.GetCppThis(), extent, (outInfo == null) ? default(HandleRef) : outInfo.GetCppThis());
		}

		// Token: 0x0601621A RID: 90650
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageClip_SetOutputWholeExtent_16(HandleRef pThis, int minX, int maxX, int minY, int maxY, int minZ, int maxZ);

		/// <summary>
		/// The whole extent of the output has to be set explicitly.
		/// </summary>
		// Token: 0x0601621B RID: 90651 RVA: 0x001F27C4 File Offset: 0x001F09C4
		public void SetOutputWholeExtent(int minX, int maxX, int minY, int maxY, int minZ, int maxZ)
		{
			vtkImageClip.vtkImageClip_SetOutputWholeExtent_16(base.GetCppThis(), minX, maxX, minY, maxY, minZ, maxZ);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018FC RID: 6396
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageClip";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040018FD RID: 6397
		public new static readonly string MRClassNameKey = "class vtkImageClip";
	}
}
