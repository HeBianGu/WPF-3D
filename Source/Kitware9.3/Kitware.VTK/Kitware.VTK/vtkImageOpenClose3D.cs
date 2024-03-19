using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageOpenClose3D
	/// </summary>
	/// <remarks>
	///    Will perform opening or closing.
	///
	/// vtkImageOpenClose3D performs opening or closing by having two
	/// vtkImageErodeDilates in series.  The size of operation
	/// is determined by the method SetKernelSize, and the operator is an ellipse.
	/// OpenValue and CloseValue determine how the filter behaves.  For binary
	/// images Opening and closing behaves as expected.
	/// Close value is first dilated, and then eroded.
	/// Open value is first eroded, and then dilated.
	/// Degenerate two dimensional opening/closing can be achieved by setting the
	/// one axis the 3D KernelSize to 1.
	/// Values other than open value and close value are not touched.
	/// This enables the filter to processes segmented images containing more than
	/// two tags.
	/// </remarks>
	// Token: 0x0200024D RID: 589
	public class vtkImageOpenClose3D : vtkImageAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06006D17 RID: 27927 RVA: 0x0009D6CF File Offset: 0x0009B8CF
		static vtkImageOpenClose3D()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageOpenClose3D.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageOpenClose3D"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06006D18 RID: 27928 RVA: 0x0009D6F7 File Offset: 0x0009B8F7
		public vtkImageOpenClose3D(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06006D19 RID: 27929
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageOpenClose3D_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Default open value is 0, and default close value is 255.
		/// </summary>
		// Token: 0x06006D1A RID: 27930 RVA: 0x0009D708 File Offset: 0x0009B908
		public new static vtkImageOpenClose3D New()
		{
			vtkImageOpenClose3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageOpenClose3D.vtkImageOpenClose3D_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageOpenClose3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		/// Default open value is 0, and default close value is 255.
		/// </summary>
		// Token: 0x06006D1B RID: 27931 RVA: 0x0009D75C File Offset: 0x0009B95C
		public vtkImageOpenClose3D() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageOpenClose3D.vtkImageOpenClose3D_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06006D1C RID: 27932 RVA: 0x0009D7A0 File Offset: 0x0009B9A0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06006D1D RID: 27933
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageOpenClose3D_DebugOff_01(HandleRef pThis);

		/// <summary>
		/// Turn debugging output on. (in sub filters also)
		/// </summary>
		// Token: 0x06006D1E RID: 27934 RVA: 0x0009D7AB File Offset: 0x0009B9AB
		public override void DebugOff()
		{
			vtkImageOpenClose3D.vtkImageOpenClose3D_DebugOff_01(base.GetCppThis());
		}

		// Token: 0x06006D1F RID: 27935
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageOpenClose3D_DebugOn_02(HandleRef pThis);

		/// <summary>
		/// Turn debugging output on. (in sub filters also)
		/// </summary>
		// Token: 0x06006D20 RID: 27936 RVA: 0x0009D7BA File Offset: 0x0009B9BA
		public override void DebugOn()
		{
			vtkImageOpenClose3D.vtkImageOpenClose3D_DebugOn_02(base.GetCppThis());
		}

		// Token: 0x06006D21 RID: 27937
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageOpenClose3D_GetCloseValue_03(HandleRef pThis);

		/// <summary>
		/// Determines the value that will closed.
		/// Close value is first dilated, and then eroded
		/// </summary>
		// Token: 0x06006D22 RID: 27938 RVA: 0x0009D7CC File Offset: 0x0009B9CC
		public double GetCloseValue()
		{
			return vtkImageOpenClose3D.vtkImageOpenClose3D_GetCloseValue_03(base.GetCppThis());
		}

		// Token: 0x06006D23 RID: 27939
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageOpenClose3D_GetFilter0_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Needed for Progress functions
		/// </summary>
		// Token: 0x06006D24 RID: 27940 RVA: 0x0009D7EC File Offset: 0x0009B9EC
		public virtual vtkImageDilateErode3D GetFilter0()
		{
			vtkImageDilateErode3D vtkImageDilateErode3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageOpenClose3D.vtkImageOpenClose3D_GetFilter0_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageDilateErode3D = (vtkImageDilateErode3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageDilateErode3D.Register(null);
				}
			}
			return vtkImageDilateErode3D;
		}

		// Token: 0x06006D25 RID: 27941
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageOpenClose3D_GetFilter1_05(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Needed for Progress functions
		/// </summary>
		// Token: 0x06006D26 RID: 27942 RVA: 0x0009D85C File Offset: 0x0009BA5C
		public virtual vtkImageDilateErode3D GetFilter1()
		{
			vtkImageDilateErode3D vtkImageDilateErode3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageOpenClose3D.vtkImageOpenClose3D_GetFilter1_05(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageDilateErode3D = (vtkImageDilateErode3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageDilateErode3D.Register(null);
				}
			}
			return vtkImageDilateErode3D;
		}

		// Token: 0x06006D27 RID: 27943
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern ulong vtkImageOpenClose3D_GetMTime_06(HandleRef pThis);

		/// <summary>
		/// This method considers the sub filters MTimes when computing this objects
		/// modified time.
		/// </summary>
		// Token: 0x06006D28 RID: 27944 RVA: 0x0009D8CC File Offset: 0x0009BACC
		public override ulong GetMTime()
		{
			return vtkImageOpenClose3D.vtkImageOpenClose3D_GetMTime_06(base.GetCppThis());
		}

		// Token: 0x06006D29 RID: 27945
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageOpenClose3D_GetNumberOfGenerationsFromBase_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Default open value is 0, and default close value is 255.
		/// </summary>
		// Token: 0x06006D2A RID: 27946 RVA: 0x0009D8EC File Offset: 0x0009BAEC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageOpenClose3D.vtkImageOpenClose3D_GetNumberOfGenerationsFromBase_07(base.GetCppThis(), type);
		}

		// Token: 0x06006D2B RID: 27947
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageOpenClose3D_GetNumberOfGenerationsFromBaseType_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Default open value is 0, and default close value is 255.
		/// </summary>
		// Token: 0x06006D2C RID: 27948 RVA: 0x0009D90C File Offset: 0x0009BB0C
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageOpenClose3D.vtkImageOpenClose3D_GetNumberOfGenerationsFromBaseType_08(type);
		}

		// Token: 0x06006D2D RID: 27949
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern double vtkImageOpenClose3D_GetOpenValue_09(HandleRef pThis);

		/// <summary>
		/// Determines the value that will opened.
		/// Open value is first eroded, and then dilated.
		/// </summary>
		// Token: 0x06006D2E RID: 27950 RVA: 0x0009D928 File Offset: 0x0009BB28
		public double GetOpenValue()
		{
			return vtkImageOpenClose3D.vtkImageOpenClose3D_GetOpenValue_09(base.GetCppThis());
		}

		// Token: 0x06006D2F RID: 27951
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageOpenClose3D_IsA_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Default open value is 0, and default close value is 255.
		/// </summary>
		// Token: 0x06006D30 RID: 27952 RVA: 0x0009D948 File Offset: 0x0009BB48
		public override int IsA(string type)
		{
			return vtkImageOpenClose3D.vtkImageOpenClose3D_IsA_10(base.GetCppThis(), type);
		}

		// Token: 0x06006D31 RID: 27953
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageOpenClose3D_IsTypeOf_11([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		/// Default open value is 0, and default close value is 255.
		/// </summary>
		// Token: 0x06006D32 RID: 27954 RVA: 0x0009D968 File Offset: 0x0009BB68
		public new static int IsTypeOf(string type)
		{
			return vtkImageOpenClose3D.vtkImageOpenClose3D_IsTypeOf_11(type);
		}

		// Token: 0x06006D33 RID: 27955
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageOpenClose3D_Modified_12(HandleRef pThis);

		/// <summary>
		/// Pass modified message to sub filters.
		/// </summary>
		// Token: 0x06006D34 RID: 27956 RVA: 0x0009D982 File Offset: 0x0009BB82
		public override void Modified()
		{
			vtkImageOpenClose3D.vtkImageOpenClose3D_Modified_12(base.GetCppThis());
		}

		// Token: 0x06006D35 RID: 27957
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageOpenClose3D_NewInstance_14(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Default open value is 0, and default close value is 255.
		/// </summary>
		// Token: 0x06006D36 RID: 27958 RVA: 0x0009D994 File Offset: 0x0009BB94
		public new vtkImageOpenClose3D NewInstance()
		{
			vtkImageOpenClose3D result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageOpenClose3D.vtkImageOpenClose3D_NewInstance_14(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageOpenClose3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06006D37 RID: 27959
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageOpenClose3D_SafeDownCast_15(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Default open value is 0, and default close value is 255.
		/// </summary>
		// Token: 0x06006D38 RID: 27960 RVA: 0x0009D9F0 File Offset: 0x0009BBF0
		public new static vtkImageOpenClose3D SafeDownCast(vtkObjectBase o)
		{
			vtkImageOpenClose3D vtkImageOpenClose3D = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageOpenClose3D.vtkImageOpenClose3D_SafeDownCast_15((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageOpenClose3D = (vtkImageOpenClose3D)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageOpenClose3D.Register(null);
				}
			}
			return vtkImageOpenClose3D;
		}

		// Token: 0x06006D39 RID: 27961
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageOpenClose3D_SetCloseValue_16(HandleRef pThis, double value);

		/// <summary>
		/// Determines the value that will closed.
		/// Close value is first dilated, and then eroded
		/// </summary>
		// Token: 0x06006D3A RID: 27962 RVA: 0x0009DA6F File Offset: 0x0009BC6F
		public void SetCloseValue(double value)
		{
			vtkImageOpenClose3D.vtkImageOpenClose3D_SetCloseValue_16(base.GetCppThis(), value);
		}

		// Token: 0x06006D3B RID: 27963
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageOpenClose3D_SetKernelSize_17(HandleRef pThis, int size0, int size1, int size2);

		/// <summary>
		/// Selects the size of gaps or objects removed.
		/// </summary>
		// Token: 0x06006D3C RID: 27964 RVA: 0x0009DA7F File Offset: 0x0009BC7F
		public void SetKernelSize(int size0, int size1, int size2)
		{
			vtkImageOpenClose3D.vtkImageOpenClose3D_SetKernelSize_17(base.GetCppThis(), size0, size1, size2);
		}

		// Token: 0x06006D3D RID: 27965
		[DllImport("Kitware.VTK.ImagingMorphological.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageOpenClose3D_SetOpenValue_18(HandleRef pThis, double value);

		/// <summary>
		/// Determines the value that will opened.
		/// Open value is first eroded, and then dilated.
		/// </summary>
		// Token: 0x06006D3E RID: 27966 RVA: 0x0009DA91 File Offset: 0x0009BC91
		public void SetOpenValue(double value)
		{
			vtkImageOpenClose3D.vtkImageOpenClose3D_SetOpenValue_18(base.GetCppThis(), value);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400098F RID: 2447
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageOpenClose3D";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000990 RID: 2448
		public new static readonly string MRClassNameKey = "class vtkImageOpenClose3D";
	}
}
