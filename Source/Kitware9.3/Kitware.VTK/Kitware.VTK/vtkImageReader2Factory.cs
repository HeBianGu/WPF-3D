using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkImageReader2Factory
	/// </summary>
	/// <remarks>
	///    Superclass of binary file readers.
	///
	/// vtkImageReader2Factory: This class is used to create a vtkImageReader2
	/// object given a path name to a file.  It calls CanReadFile on all
	/// available readers until one of them returns true.  The available reader
	/// list comes from three places.  In the InitializeReaders function of this
	/// class, built-in VTK classes are added to the list, users can call
	/// RegisterReader, or users can create a vtkObjectFactory that has
	/// CreateObject method that returns a new vtkImageReader2 sub class when
	/// given the string "vtkImageReaderObject".  This way applications can be
	/// extended with new readers via a plugin dll or by calling RegisterReader.
	/// Of course all of the readers that are part of the vtk release are made
	/// automatically available.
	///
	/// </remarks>
	/// <seealso>
	///
	/// vtkImageReader2
	/// </seealso>
	// Token: 0x02000787 RID: 1927
	public class vtkImageReader2Factory : vtkObject
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06013C9E RID: 81054 RVA: 0x001BF743 File Offset: 0x001BD943
		static vtkImageReader2Factory()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkImageReader2Factory.MRClassNameKey, Type.GetType("Kitware.VTK.vtkImageReader2Factory"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06013C9F RID: 81055 RVA: 0x001BF76B File Offset: 0x001BD96B
		public vtkImageReader2Factory(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06013CA0 RID: 81056
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageReader2Factory_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013CA1 RID: 81057 RVA: 0x001BF77C File Offset: 0x001BD97C
		public new static vtkImageReader2Factory New()
		{
			vtkImageReader2Factory result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageReader2Factory.vtkImageReader2Factory_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageReader2Factory)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013CA2 RID: 81058 RVA: 0x001BF7D0 File Offset: 0x001BD9D0
		public vtkImageReader2Factory() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkImageReader2Factory.vtkImageReader2Factory_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06013CA3 RID: 81059 RVA: 0x001BF814 File Offset: 0x001BDA14
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06013CA4 RID: 81060
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern byte vtkImageReader2Factory_CheckExtensionIsInExtensions_01([MarshalAs(UnmanagedType.LPUTF8Str)] string extension, [MarshalAs(UnmanagedType.LPUTF8Str)] string extensions);

		/// <summary>
		/// The caller must allocate the vtkImageReader2Collection and pass in the
		/// pointer to this method.
		/// </summary>
		// Token: 0x06013CA5 RID: 81061 RVA: 0x001BF820 File Offset: 0x001BDA20
		public static bool CheckExtensionIsInExtensions(string extension, string extensions)
		{
			return vtkImageReader2Factory.vtkImageReader2Factory_CheckExtensionIsInExtensions_01(extension, extensions) != 0;
		}

		// Token: 0x06013CA6 RID: 81062
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageReader2Factory_CreateImageReader2_02([MarshalAs(UnmanagedType.LPUTF8Str)] string path, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// open the image file, it is the callers responsibility to call
		/// Delete on the returned object. If no reader is found, nullptr
		/// is returned.
		/// </summary>
		// Token: 0x06013CA7 RID: 81063 RVA: 0x001BF844 File Offset: 0x001BDA44
		public static vtkImageReader2 CreateImageReader2(string path)
		{
			vtkImageReader2 result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageReader2Factory.vtkImageReader2Factory_CreateImageReader2_02(path, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageReader2)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06013CA8 RID: 81064
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageReader2Factory_CreateImageReader2FromExtension_03([MarshalAs(UnmanagedType.LPUTF8Str)] string extension, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Create a vtkImageReader2 from a (dotted or not) file extension.
		/// If multiple readers support the same extension, only one reader
		/// will be returned.
		/// It is the callers responsibility to call Delete on the returned object.
		/// If no reader is found, nullptr is returned.
		/// </summary>
		// Token: 0x06013CA9 RID: 81065 RVA: 0x001BF89C File Offset: 0x001BDA9C
		public static vtkImageReader2 CreateImageReader2FromExtension(string extension)
		{
			vtkImageReader2 vtkImageReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageReader2Factory.vtkImageReader2Factory_CreateImageReader2FromExtension_03(extension, ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageReader = (vtkImageReader2)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageReader.Register(null);
				}
			}
			return vtkImageReader;
		}

		// Token: 0x06013CAA RID: 81066
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageReader2Factory_GetNumberOfGenerationsFromBase_04(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013CAB RID: 81067 RVA: 0x001BF908 File Offset: 0x001BDB08
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkImageReader2Factory.vtkImageReader2Factory_GetNumberOfGenerationsFromBase_04(base.GetCppThis(), type);
		}

		// Token: 0x06013CAC RID: 81068
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkImageReader2Factory_GetNumberOfGenerationsFromBaseType_05([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013CAD RID: 81069 RVA: 0x001BF928 File Offset: 0x001BDB28
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkImageReader2Factory.vtkImageReader2Factory_GetNumberOfGenerationsFromBaseType_05(type);
		}

		// Token: 0x06013CAE RID: 81070
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReader2Factory_GetRegisteredReaders_06(HandleRef arg0);

		/// <summary>
		/// The caller must allocate the vtkImageReader2Collection and pass in the
		/// pointer to this method.
		/// </summary>
		// Token: 0x06013CAF RID: 81071 RVA: 0x001BF944 File Offset: 0x001BDB44
		public static void GetRegisteredReaders(vtkImageReader2Collection arg0)
		{
			vtkImageReader2Factory.vtkImageReader2Factory_GetRegisteredReaders_06((arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		// Token: 0x06013CB0 RID: 81072
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageReader2Factory_IsA_07(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013CB1 RID: 81073 RVA: 0x001BF970 File Offset: 0x001BDB70
		public override int IsA(string type)
		{
			return vtkImageReader2Factory.vtkImageReader2Factory_IsA_07(base.GetCppThis(), type);
		}

		// Token: 0x06013CB2 RID: 81074
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkImageReader2Factory_IsTypeOf_08([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013CB3 RID: 81075 RVA: 0x001BF990 File Offset: 0x001BDB90
		public new static int IsTypeOf(string type)
		{
			return vtkImageReader2Factory.vtkImageReader2Factory_IsTypeOf_08(type);
		}

		// Token: 0x06013CB4 RID: 81076
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageReader2Factory_NewInstance_10(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013CB5 RID: 81077 RVA: 0x001BF9AC File Offset: 0x001BDBAC
		public new vtkImageReader2Factory NewInstance()
		{
			vtkImageReader2Factory result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageReader2Factory.vtkImageReader2Factory_NewInstance_10(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkImageReader2Factory)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06013CB6 RID: 81078
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkImageReader2Factory_RegisterReader_11(HandleRef r);

		/// <summary>
		/// registered readers will be queried in CreateImageReader2 to
		/// see if they can load a given file.
		/// </summary>
		// Token: 0x06013CB7 RID: 81079 RVA: 0x001BFA08 File Offset: 0x001BDC08
		public static void RegisterReader(vtkImageReader2 r)
		{
			vtkImageReader2Factory.vtkImageReader2Factory_RegisterReader_11((r == null) ? default(HandleRef) : r.GetCppThis());
		}

		// Token: 0x06013CB8 RID: 81080
		[DllImport("Kitware.VTK.IOImage.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkImageReader2Factory_SafeDownCast_12(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06013CB9 RID: 81081 RVA: 0x001BFA34 File Offset: 0x001BDC34
		public new static vtkImageReader2Factory SafeDownCast(vtkObjectBase o)
		{
			vtkImageReader2Factory vtkImageReader2Factory = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkImageReader2Factory.vtkImageReader2Factory_SafeDownCast_12((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkImageReader2Factory = (vtkImageReader2Factory)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkImageReader2Factory.Register(null);
				}
			}
			return vtkImageReader2Factory;
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040016C0 RID: 5824
		public new const string MRFullTypeName = "Kitware.VTK.vtkImageReader2Factory";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x040016C1 RID: 5825
		public new static readonly string MRClassNameKey = "class vtkImageReader2Factory";
	}
}
