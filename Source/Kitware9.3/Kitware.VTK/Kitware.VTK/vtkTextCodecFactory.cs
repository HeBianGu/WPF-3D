using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkTextCodecFactory
	/// </summary>
	/// <remarks>
	///    maintain a list of text codecs and return instances
	///
	///
	/// A single class to hold registered codecs and return instances of them based
	/// on either a descriptive name (UTF16 or latin-1) or by asking who can handle a
	/// given std::vector&lt;unsigned char&gt;
	///
	/// @par Thanks:
	/// Thanks to Tim Shed from Sandia National Laboratories for his work
	/// on the concepts and to Marcus Hanwell and Jeff Baumes of Kitware for
	/// keeping me out of the weeds
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkTextCodec
	///
	/// </seealso>
	// Token: 0x02000733 RID: 1843
	public class vtkTextCodecFactory : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06013393 RID: 78739 RVA: 0x001B2E3C File Offset: 0x001B103C
		static vtkTextCodecFactory()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkTextCodecFactory.MRClassNameKey, Type.GetType("Kitware.VTK.vtkTextCodecFactory"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06013394 RID: 78740 RVA: 0x001B2E64 File Offset: 0x001B1064
		public vtkTextCodecFactory(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06013395 RID: 78741
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextCodecFactory_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013396 RID: 78742 RVA: 0x001B2E74 File Offset: 0x001B1074
		public new static vtkTextCodecFactory New()
		{
			vtkTextCodecFactory result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTextCodecFactory.vtkTextCodecFactory_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTextCodecFactory)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013397 RID: 78743 RVA: 0x001B2EC8 File Offset: 0x001B10C8
		public vtkTextCodecFactory() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkTextCodecFactory.vtkTextCodecFactory_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06013398 RID: 78744 RVA: 0x001B2F0C File Offset: 0x001B110C
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06013399 RID: 78745
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextCodecFactory_CodecForName_01([MarshalAs(UnmanagedType.LPUTF8Str)] string CodecName, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Given a codec/storage name try to find one of our registered codecs that
		/// can handle it.  This is non-deterministic, very messy and should not be
		/// your first thing to try.
		/// The registered callbacks are tried in the order they are registered.
		/// </summary>
		// Token: 0x0601339A RID: 78746 RVA: 0x001B2F18 File Offset: 0x001B1118
		public static vtkTextCodec CodecForName(string CodecName)
		{
			vtkTextCodec vtkTextCodec = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTextCodecFactory.vtkTextCodecFactory_CodecForName_01(CodecName, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextCodec = (vtkTextCodec)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextCodec.Register(null);
				}
			}
			return vtkTextCodec;
		}

		// Token: 0x0601339B RID: 78747
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTextCodecFactory_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601339C RID: 78748 RVA: 0x001B2F84 File Offset: 0x001B1184
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkTextCodecFactory.vtkTextCodecFactory_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0601339D RID: 78749
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkTextCodecFactory_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601339E RID: 78750 RVA: 0x001B2FA4 File Offset: 0x001B11A4
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkTextCodecFactory.vtkTextCodecFactory_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0601339F RID: 78751
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextCodecFactory_Initialize_04();

		/// <summary>
		/// Initialize core text codecs - needed for the static compilation case.
		/// </summary>
		// Token: 0x060133A0 RID: 78752 RVA: 0x001B2FBE File Offset: 0x001B11BE
		public static void Initialize()
		{
			vtkTextCodecFactory.vtkTextCodecFactory_Initialize_04();
		}

		// Token: 0x060133A1 RID: 78753
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextCodecFactory_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060133A2 RID: 78754 RVA: 0x001B2FC8 File Offset: 0x001B11C8
		public override int IsA(string type)
		{
			return vtkTextCodecFactory.vtkTextCodecFactory_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x060133A3 RID: 78755
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkTextCodecFactory_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060133A4 RID: 78756 RVA: 0x001B2FE8 File Offset: 0x001B11E8
		public new static int IsTypeOf(string type)
		{
			return vtkTextCodecFactory.vtkTextCodecFactory_IsTypeOf_06(type);
		}

		// Token: 0x060133A5 RID: 78757
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextCodecFactory_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060133A6 RID: 78758 RVA: 0x001B3004 File Offset: 0x001B1204
		public new vtkTextCodecFactory NewInstance()
		{
			vtkTextCodecFactory result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTextCodecFactory.vtkTextCodecFactory_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkTextCodecFactory)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x060133A7 RID: 78759
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextCodecFactory_RegisterCreateCallback_09(vtkTextCodecFactory.CreateFunction callback);

		/// <summary>
		/// Provides mechanism to register/unregister additional callbacks to create
		/// concrete subclasses of vtkTextCodecFactory to handle different protocols.
		/// The registered callbacks are tried in the order they are registered.
		/// </summary>
		// Token: 0x060133A8 RID: 78760 RVA: 0x001B305E File Offset: 0x001B125E
		public static void RegisterCreateCallback(vtkTextCodecFactory.CreateFunction callback)
		{
			vtkTextCodecFactory.vtkTextCodecFactory_RegisterCreateCallback_09(callback);
		}

		// Token: 0x060133A9 RID: 78761
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkTextCodecFactory_SafeDownCast_10(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060133AA RID: 78762 RVA: 0x001B3068 File Offset: 0x001B1268
		public new static vtkTextCodecFactory SafeDownCast(vtkObjectBase o)
		{
			vtkTextCodecFactory vtkTextCodecFactory = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkTextCodecFactory.vtkTextCodecFactory_SafeDownCast_10((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkTextCodecFactory = (vtkTextCodecFactory)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkTextCodecFactory.Register(null);
				}
			}
			return vtkTextCodecFactory;
		}

		// Token: 0x060133AB RID: 78763
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextCodecFactory_UnRegisterAllCreateCallbacks_11();

		/// <summary>
		/// Provides mechanism to register/unregister additional callbacks to create
		/// concrete subclasses of vtkTextCodecFactory to handle different protocols.
		/// The registered callbacks are tried in the order they are registered.
		/// </summary>
		// Token: 0x060133AC RID: 78764 RVA: 0x001B30E7 File Offset: 0x001B12E7
		public static void UnRegisterAllCreateCallbacks()
		{
			vtkTextCodecFactory.vtkTextCodecFactory_UnRegisterAllCreateCallbacks_11();
		}

		// Token: 0x060133AD RID: 78765
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkTextCodecFactory_UnRegisterCreateCallback_12(vtkTextCodecFactory.CreateFunction callback);

		/// <summary>
		/// Provides mechanism to register/unregister additional callbacks to create
		/// concrete subclasses of vtkTextCodecFactory to handle different protocols.
		/// The registered callbacks are tried in the order they are registered.
		/// </summary>
		// Token: 0x060133AE RID: 78766 RVA: 0x001B30F0 File Offset: 0x001B12F0
		public static void UnRegisterCreateCallback(vtkTextCodecFactory.CreateFunction callback)
		{
			vtkTextCodecFactory.vtkTextCodecFactory_UnRegisterCreateCallback_12(callback);
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001634 RID: 5684
		public new const string MRFullTypeName = "Kitware.VTK.vtkTextCodecFactory";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04001635 RID: 5685
		public new static readonly string MRClassNameKey = "class vtkTextCodecFactory";

		/// <summary>
		/// Type for Creation callback.
		/// </summary>
		// Token: 0x02000734 RID: 1844
		// (Invoke) Token: 0x060133B0 RID: 78768
		public delegate IntPtr CreateFunction();
	}
}
