using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkUTF8TextCodec
	/// </summary>
	/// <remarks>
	///    Class to read/write UTF-8 text
	///
	///
	/// A virtual class interface for codecs that readers/writers can rely on
	///
	/// @par Thanks:
	/// Thanks to Tim Shed from Sandia National Laboratories for his work
	/// on the concepts and to Marcus Hanwell and Jeff Baumes of Kitware for
	/// keeping me out of the weeds
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkUTF8TextCodecFactory
	///
	/// </seealso>
	// Token: 0x02000738 RID: 1848
	public class vtkUTF8TextCodec : vtkTextCodec
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06013411 RID: 78865 RVA: 0x001B3ACF File Offset: 0x001B1CCF
		static vtkUTF8TextCodec()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkUTF8TextCodec.MRClassNameKey, Type.GetType("Kitware.VTK.vtkUTF8TextCodec"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06013412 RID: 78866 RVA: 0x001B3AF7 File Offset: 0x001B1CF7
		public vtkUTF8TextCodec(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06013413 RID: 78867
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUTF8TextCodec_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013414 RID: 78868 RVA: 0x001B3B08 File Offset: 0x001B1D08
		public new static vtkUTF8TextCodec New()
		{
			vtkUTF8TextCodec result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUTF8TextCodec.vtkUTF8TextCodec_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUTF8TextCodec)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013415 RID: 78869 RVA: 0x001B3B5C File Offset: 0x001B1D5C
		public vtkUTF8TextCodec() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkUTF8TextCodec.vtkUTF8TextCodec_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06013416 RID: 78870 RVA: 0x001B3BA0 File Offset: 0x001B1DA0
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06013417 RID: 78871
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUTF8TextCodec_GetNumberOfGenerationsFromBase_01(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013418 RID: 78872 RVA: 0x001B3BAC File Offset: 0x001B1DAC
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkUTF8TextCodec.vtkUTF8TextCodec_GetNumberOfGenerationsFromBase_01(base.GetCppThis(), type);
		}

		// Token: 0x06013419 RID: 78873
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkUTF8TextCodec_GetNumberOfGenerationsFromBaseType_02([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601341A RID: 78874 RVA: 0x001B3BCC File Offset: 0x001B1DCC
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkUTF8TextCodec.vtkUTF8TextCodec_GetNumberOfGenerationsFromBaseType_02(type);
		}

		// Token: 0x0601341B RID: 78875
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUTF8TextCodec_IsA_03(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601341C RID: 78876 RVA: 0x001B3BE8 File Offset: 0x001B1DE8
		public override int IsA(string type)
		{
			return vtkUTF8TextCodec.vtkUTF8TextCodec_IsA_03(base.GetCppThis(), type);
		}

		// Token: 0x0601341D RID: 78877
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkUTF8TextCodec_IsTypeOf_04([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0601341E RID: 78878 RVA: 0x001B3C08 File Offset: 0x001B1E08
		public new static int IsTypeOf(string type)
		{
			return vtkUTF8TextCodec.vtkUTF8TextCodec_IsTypeOf_04(type);
		}

		// Token: 0x0601341F RID: 78879
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUTF8TextCodec_Name_05(HandleRef pThis);

		/// <summary>
		/// The name this codec goes by - should match the string the factory will take to create it
		/// </summary>
		// Token: 0x06013420 RID: 78880 RVA: 0x001B3C24 File Offset: 0x001B1E24
		public override string Name()
		{
			string s = Marshal.PtrToStringAnsi(vtkUTF8TextCodec.vtkUTF8TextCodec_Name_05(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x06013421 RID: 78881
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUTF8TextCodec_NewInstance_07(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013422 RID: 78882 RVA: 0x001B3C60 File Offset: 0x001B1E60
		public new vtkUTF8TextCodec NewInstance()
		{
			vtkUTF8TextCodec result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUTF8TextCodec.vtkUTF8TextCodec_NewInstance_07(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkUTF8TextCodec)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06013423 RID: 78883
		[DllImport("Kitware.VTK.IOCore.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkUTF8TextCodec_SafeDownCast_08(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013424 RID: 78884 RVA: 0x001B3CBC File Offset: 0x001B1EBC
		public new static vtkUTF8TextCodec SafeDownCast(vtkObjectBase o)
		{
			vtkUTF8TextCodec vtkUTF8TextCodec = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkUTF8TextCodec.vtkUTF8TextCodec_SafeDownCast_08((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkUTF8TextCodec = (vtkUTF8TextCodec)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkUTF8TextCodec.Register(null);
				}
			}
			return vtkUTF8TextCodec;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400163C RID: 5692
		public new const string MRFullTypeName = "Kitware.VTK.vtkUTF8TextCodec";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400163D RID: 5693
		public new static readonly string MRClassNameKey = "class vtkUTF8TextCodec";
	}
}
