using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkCMLMoleculeReader
	/// </summary>
	/// <remarks>
	///    Read a CML file and output a
	/// vtkMolecule object
	///
	/// </remarks>
	// Token: 0x020001CC RID: 460
	public class vtkCMLMoleculeReader : vtkMoleculeAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x06005933 RID: 22835 RVA: 0x00080BEB File Offset: 0x0007EDEB
		static vtkCMLMoleculeReader()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkCMLMoleculeReader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkCMLMoleculeReader"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x06005934 RID: 22836 RVA: 0x00080C13 File Offset: 0x0007EE13
		public vtkCMLMoleculeReader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x06005935 RID: 22837
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCMLMoleculeReader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005936 RID: 22838 RVA: 0x00080C24 File Offset: 0x0007EE24
		public new static vtkCMLMoleculeReader New()
		{
			vtkCMLMoleculeReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCMLMoleculeReader.vtkCMLMoleculeReader_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCMLMoleculeReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005937 RID: 22839 RVA: 0x00080C78 File Offset: 0x0007EE78
		public vtkCMLMoleculeReader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkCMLMoleculeReader.vtkCMLMoleculeReader_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x06005938 RID: 22840 RVA: 0x00080CBC File Offset: 0x0007EEBC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x06005939 RID: 22841
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCMLMoleculeReader_GetFileName_01(HandleRef pThis);

		/// <summary>
		/// Get/Set the name of the CML file
		/// </summary>
		// Token: 0x0600593A RID: 22842 RVA: 0x00080CC8 File Offset: 0x0007EEC8
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkCMLMoleculeReader.vtkCMLMoleculeReader_GetFileName_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x0600593B RID: 22843
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCMLMoleculeReader_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600593C RID: 22844 RVA: 0x00080D04 File Offset: 0x0007EF04
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkCMLMoleculeReader.vtkCMLMoleculeReader_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x0600593D RID: 22845
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkCMLMoleculeReader_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x0600593E RID: 22846 RVA: 0x00080D24 File Offset: 0x0007EF24
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkCMLMoleculeReader.vtkCMLMoleculeReader_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x0600593F RID: 22847
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCMLMoleculeReader_GetOutput_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the output (vtkMolecule) that the reader will fill
		/// </summary>
		// Token: 0x06005940 RID: 22848 RVA: 0x00080D40 File Offset: 0x0007EF40
		public new vtkMolecule GetOutput()
		{
			vtkMolecule vtkMolecule = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCMLMoleculeReader.vtkCMLMoleculeReader_GetOutput_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkMolecule = (vtkMolecule)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkMolecule.Register(null);
				}
			}
			return vtkMolecule;
		}

		// Token: 0x06005941 RID: 22849
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCMLMoleculeReader_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005942 RID: 22850 RVA: 0x00080DB0 File Offset: 0x0007EFB0
		public override int IsA(string type)
		{
			return vtkCMLMoleculeReader.vtkCMLMoleculeReader_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06005943 RID: 22851
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkCMLMoleculeReader_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005944 RID: 22852 RVA: 0x00080DD0 File Offset: 0x0007EFD0
		public new static int IsTypeOf(string type)
		{
			return vtkCMLMoleculeReader.vtkCMLMoleculeReader_IsTypeOf_06(type);
		}

		// Token: 0x06005945 RID: 22853
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCMLMoleculeReader_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005946 RID: 22854 RVA: 0x00080DEC File Offset: 0x0007EFEC
		public new vtkCMLMoleculeReader NewInstance()
		{
			vtkCMLMoleculeReader result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCMLMoleculeReader.vtkCMLMoleculeReader_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkCMLMoleculeReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06005947 RID: 22855
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkCMLMoleculeReader_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005948 RID: 22856 RVA: 0x00080E48 File Offset: 0x0007F048
		public new static vtkCMLMoleculeReader SafeDownCast(vtkObjectBase o)
		{
			vtkCMLMoleculeReader vtkCMLMoleculeReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkCMLMoleculeReader.vtkCMLMoleculeReader_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkCMLMoleculeReader = (vtkCMLMoleculeReader)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkCMLMoleculeReader.Register(null);
				}
			}
			return vtkCMLMoleculeReader;
		}

		// Token: 0x06005949 RID: 22857
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCMLMoleculeReader_SetFileName_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string _arg);

		/// <summary>
		/// Get/Set the name of the CML file
		/// </summary>
		// Token: 0x0600594A RID: 22858 RVA: 0x00080EC7 File Offset: 0x0007F0C7
		public virtual void SetFileName(string _arg)
		{
			vtkCMLMoleculeReader.vtkCMLMoleculeReader_SetFileName_10(base.GetCppThis(), _arg);
		}

		// Token: 0x0600594B RID: 22859
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkCMLMoleculeReader_SetOutput_11(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Get/Set the output (vtkMolecule) that the reader will fill
		/// </summary>
		// Token: 0x0600594C RID: 22860 RVA: 0x00080ED8 File Offset: 0x0007F0D8
		public override void SetOutput(vtkMolecule arg0)
		{
			vtkCMLMoleculeReader.vtkCMLMoleculeReader_SetOutput_11(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400085F RID: 2143
		public new const string MRFullTypeName = "Kitware.VTK.vtkCMLMoleculeReader";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000860 RID: 2144
		public new static readonly string MRClassNameKey = "class vtkCMLMoleculeReader";
	}
}
