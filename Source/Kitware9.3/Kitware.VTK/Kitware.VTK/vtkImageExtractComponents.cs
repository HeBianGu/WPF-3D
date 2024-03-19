using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageExtractComponents
	/// </summary>
	/// <remarks>
	///    Outputs a single component
	///
	/// vtkImageExtractComponents takes an input with any number of components
	/// and outputs some of them.  It does involve a copy of the data.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkImageAppendComponents
	/// </seealso>
	// Token: 0x02000858 RID: 2136
	public class vtkImageExtractComponents : vtkThreadedImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06016288 RID: 90760 RVA: 0x001F3197 File Offset: 0x001F1397
		static vtkImageExtractComponents()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageExtractComponents.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageExtractComponents"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06016289 RID: 90761 RVA: 0x001F31BF File Offset: 0x001F13BF
		public vtkImageExtractComponents(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x0601628A RID: 90762
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageExtractComponents_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601628B RID: 90763 RVA: 0x001F31D0 File Offset: 0x001F13D0
		public new static vtkImageExtractComponents New()
		{
			vtkImageExtractComponents result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageExtractComponents.vtkImageExtractComponents_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageExtractComponents)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601628C RID: 90764 RVA: 0x001F3224 File Offset: 0x001F1424
		public vtkImageExtractComponents() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageExtractComponents.vtkImageExtractComponents_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x0601628D RID: 90765 RVA: 0x001F3268 File Offset: 0x001F1468
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x0601628E RID: 90766
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageExtractComponents_GetComponents_01(HandleRef pThis);

		/// <summary>
		/// Set/Get the components to extract.
		/// </summary>
		// Token: 0x0601628F RID: 90767 RVA: 0x001F3274 File Offset: 0x001F1474
		public virtual int[] GetComponents()
		{
			IntPtr intPtr = vtkImageExtractComponents.vtkImageExtractComponents_GetComponents_01(base.GetCppThis());
			int[] array = null;
			if (IntPtr.Zero != intPtr)
			{
				array = new int[3];
				Marshal.Copy(intPtr, array, 0, array.Length);
			}
			return array;
		}

		// Token: 0x06016290 RID: 90768
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageExtractComponents_GetComponents_02(HandleRef pThis, ref int _arg1, ref int _arg2, ref int _arg3);

		/// <summary>
		/// Set/Get the components to extract.
		/// </summary>
		// Token: 0x06016291 RID: 90769 RVA: 0x001F32BC File Offset: 0x001F14BC
		public virtual void GetComponents(ref int _arg1, ref int _arg2, ref int _arg3)
		{
			vtkImageExtractComponents.vtkImageExtractComponents_GetComponents_02(base.GetCppThis(), ref _arg1, ref _arg2, ref _arg3);
		}

		// Token: 0x06016292 RID: 90770
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageExtractComponents_GetComponents_03(HandleRef pThis, IntPtr _arg);

		/// <summary>
		/// Set/Get the components to extract.
		/// </summary>
		// Token: 0x06016293 RID: 90771 RVA: 0x001F32CE File Offset: 0x001F14CE
		public virtual void GetComponents(IntPtr _arg)
		{
			vtkImageExtractComponents.vtkImageExtractComponents_GetComponents_03(base.GetCppThis(), _arg);
		}

		// Token: 0x06016294 RID: 90772
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageExtractComponents_GetNumberOfComponents_04(HandleRef pThis);

		/// <summary>
		/// Get the number of components to extract. This is set implicitly by the
		/// SetComponents() method.
		/// </summary>
		// Token: 0x06016295 RID: 90773 RVA: 0x001F32E0 File Offset: 0x001F14E0
		public virtual int GetNumberOfComponents()
		{
			return vtkImageExtractComponents.vtkImageExtractComponents_GetNumberOfComponents_04(base.GetCppThis());
		}

		// Token: 0x06016296 RID: 90774
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageExtractComponents_GetNumberOfGenerationsFromBase_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016297 RID: 90775 RVA: 0x001F3300 File Offset: 0x001F1500
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageExtractComponents.vtkImageExtractComponents_GetNumberOfGenerationsFromBase_05(base.GetCppThis(), type);
		}

		// Token: 0x06016298 RID: 90776
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageExtractComponents_GetNumberOfGenerationsFromBaseType_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06016299 RID: 90777 RVA: 0x001F3320 File Offset: 0x001F1520
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageExtractComponents.vtkImageExtractComponents_GetNumberOfGenerationsFromBaseType_06(type);
		}

		// Token: 0x0601629A RID: 90778
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageExtractComponents_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601629B RID: 90779 RVA: 0x001F333C File Offset: 0x001F153C
		public override int IsA(string type)
		{
			return vtkImageExtractComponents.vtkImageExtractComponents_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x0601629C RID: 90780
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageExtractComponents_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601629D RID: 90781 RVA: 0x001F335C File Offset: 0x001F155C
		public new static int IsTypeOf(string type)
		{
			return vtkImageExtractComponents.vtkImageExtractComponents_IsTypeOf_08(type);
		}

		// Token: 0x0601629E RID: 90782
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageExtractComponents_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601629F RID: 90783 RVA: 0x001F3378 File Offset: 0x001F1578
		public new vtkImageExtractComponents NewInstance()
		{
			vtkImageExtractComponents result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageExtractComponents.vtkImageExtractComponents_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageExtractComponents)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060162A0 RID: 90784
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageExtractComponents_SafeDownCast_11(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060162A1 RID: 90785 RVA: 0x001F33D4 File Offset: 0x001F15D4
		public new static vtkImageExtractComponents SafeDownCast(vtkObjectBase o)
		{
			vtkImageExtractComponents vtkImageExtractComponents = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageExtractComponents.vtkImageExtractComponents_SafeDownCast_11((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageExtractComponents = (vtkImageExtractComponents)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageExtractComponents.Register(null);
				}
			}
			return vtkImageExtractComponents;
		}

		// Token: 0x060162A2 RID: 90786
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageExtractComponents_SetComponents_12(HandleRef pThis, int c1);

		/// <summary>
		/// Set/Get the components to extract.
		/// </summary>
		// Token: 0x060162A3 RID: 90787 RVA: 0x001F3453 File Offset: 0x001F1653
		public void SetComponents(int c1)
		{
			vtkImageExtractComponents.vtkImageExtractComponents_SetComponents_12(base.GetCppThis(), c1);
		}

		// Token: 0x060162A4 RID: 90788
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageExtractComponents_SetComponents_13(HandleRef pThis, int c1, int c2);

		/// <summary>
		/// Set/Get the components to extract.
		/// </summary>
		// Token: 0x060162A5 RID: 90789 RVA: 0x001F3463 File Offset: 0x001F1663
		public void SetComponents(int c1, int c2)
		{
			vtkImageExtractComponents.vtkImageExtractComponents_SetComponents_13(base.GetCppThis(), c1, c2);
		}

		// Token: 0x060162A6 RID: 90790
		[DllImport("Kitware.VTK.ImagingCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageExtractComponents_SetComponents_14(HandleRef pThis, int c1, int c2, int c3);

		/// <summary>
		/// Set/Get the components to extract.
		/// </summary>
		// Token: 0x060162A7 RID: 90791 RVA: 0x001F3474 File Offset: 0x001F1674
		public void SetComponents(int c1, int c2, int c3)
		{
			vtkImageExtractComponents.vtkImageExtractComponents_SetComponents_14(base.GetCppThis(), c1, c2, c3);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001904 RID: 6404
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageExtractComponents";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001905 RID: 6405
		public new static readonly string MRClassNameKey = "class vtkImageExtractComponents";
	}
}
