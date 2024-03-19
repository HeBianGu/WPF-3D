using System;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using Kitware.mummy.Runtime;

namespace Kitware.VTK
{
	/// <summary>
	///    vtkXYZMolReader2
	/// </summary>
	/// <remarks>
	///    read Molecular Data files
	///
	/// vtkXYZMolReader2 is a source object that reads Molecule files
	/// The reader will detect multiple timesteps in an XYZ molecule file.
	///
	/// @par Thanks:
	/// Dr. Jean M. Favre who developed and contributed this class
	/// </remarks>
	// Token: 0x020001D4 RID: 468
	public class vtkXYZMolReader2 : vtkMoleculeAlgorithm
	{
		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x060059F6 RID: 23030 RVA: 0x000821EB File Offset: 0x000803EB
		static vtkXYZMolReader2()
		{
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkXYZMolReader2.MRClassNameKey, Type.GetType("Kitware.VTK.vtkXYZMolReader2"));
		}

		/// <summary>
		/// Automatically generated constructor - called from generated code.
		/// DO NOT call directly.
		/// </summary>
		// Token: 0x060059F7 RID: 23031 RVA: 0x00082213 File Offset: 0x00080413
		public vtkXYZMolReader2(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		// Token: 0x060059F8 RID: 23032
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXYZMolReader2_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060059F9 RID: 23033 RVA: 0x00082224 File Offset: 0x00080424
		public new static vtkXYZMolReader2 New()
		{
			vtkXYZMolReader2 result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXYZMolReader2.vtkXYZMolReader2_New(ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXYZMolReader2)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060059FA RID: 23034 RVA: 0x00082278 File Offset: 0x00080478
		public vtkXYZMolReader2() : base(IntPtr.Zero, false, false)
		{
			uint num = 0U;
			uint maxValue = uint.MaxValue;
			uint num2 = 0U;
			IntPtr rawCppThis = vtkXYZMolReader2.vtkXYZMolReader2_New(ref num, ref maxValue, ref num2);
			base.SetCppThis(rawCppThis, true, num != 0U && num2 >= 2U);
		}

		/// <summary>
		/// Automatically generated protected Dispose method - called from
		/// public Dispose or the C# destructor. DO NOT call directly.
		/// </summary>
		// Token: 0x060059FB RID: 23035 RVA: 0x000822BC File Offset: 0x000804BC
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x060059FC RID: 23036
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXYZMolReader2_GetFileName_01(HandleRef pThis);

		/// <summary>
		/// Get/Set the name of the XYZ Molecule file
		/// </summary>
		// Token: 0x060059FD RID: 23037 RVA: 0x000822C8 File Offset: 0x000804C8
		public virtual string GetFileName()
		{
			string s = Marshal.PtrToStringAnsi(vtkXYZMolReader2.vtkXYZMolReader2_GetFileName_01(base.GetCppThis()));
			return Encoding.UTF8.GetString(Encoding.Default.GetBytes(s));
		}

		// Token: 0x060059FE RID: 23038
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXYZMolReader2_GetNumberOfGenerationsFromBase_02(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x060059FF RID: 23039 RVA: 0x00082304 File Offset: 0x00080504
		public override long GetNumberOfGenerationsFromBase(string type)
		{
			return vtkXYZMolReader2.vtkXYZMolReader2_GetNumberOfGenerationsFromBase_02(base.GetCppThis(), type);
		}

		// Token: 0x06005A00 RID: 23040
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern long vtkXYZMolReader2_GetNumberOfGenerationsFromBaseType_03([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005A01 RID: 23041 RVA: 0x00082324 File Offset: 0x00080524
		public new static long GetNumberOfGenerationsFromBaseType(string type)
		{
			return vtkXYZMolReader2.vtkXYZMolReader2_GetNumberOfGenerationsFromBaseType_03(type);
		}

		// Token: 0x06005A02 RID: 23042
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXYZMolReader2_GetOutput_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		/// Get/Set the output (vtkMolecule) that the reader will fill
		/// </summary>
		// Token: 0x06005A03 RID: 23043 RVA: 0x00082340 File Offset: 0x00080540
		public new vtkMolecule GetOutput()
		{
			vtkMolecule vtkMolecule = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXYZMolReader2.vtkXYZMolReader2_GetOutput_04(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
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

		// Token: 0x06005A04 RID: 23044
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXYZMolReader2_IsA_05(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005A05 RID: 23045 RVA: 0x000823B0 File Offset: 0x000805B0
		public override int IsA(string type)
		{
			return vtkXYZMolReader2.vtkXYZMolReader2_IsA_05(base.GetCppThis(), type);
		}

		// Token: 0x06005A06 RID: 23046
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern int vtkXYZMolReader2_IsTypeOf_06([MarshalAs(UnmanagedType.LPUTF8Str)] string type);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005A07 RID: 23047 RVA: 0x000823D0 File Offset: 0x000805D0
		public new static int IsTypeOf(string type)
		{
			return vtkXYZMolReader2.vtkXYZMolReader2_IsTypeOf_06(type);
		}

		// Token: 0x06005A08 RID: 23048
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXYZMolReader2_NewInstance_08(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005A09 RID: 23049 RVA: 0x000823EC File Offset: 0x000805EC
		public new vtkXYZMolReader2 NewInstance()
		{
			vtkXYZMolReader2 result = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXYZMolReader2.vtkXYZMolReader2_NewInstance_08(base.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkXYZMolReader2)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		// Token: 0x06005A0A RID: 23050
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern IntPtr vtkXYZMolReader2_SafeDownCast_09(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		/// <summary>
		///             Undocumented Block
		/// </summary>
		// Token: 0x06005A0B RID: 23051 RVA: 0x00082448 File Offset: 0x00080648
		public new static vtkXYZMolReader2 SafeDownCast(vtkObjectBase o)
		{
			vtkXYZMolReader2 vtkXYZMolReader = null;
			uint mteStatus = 0U;
			uint maxValue = uint.MaxValue;
			uint rawRefCount = 0U;
			IntPtr intPtr = vtkXYZMolReader2.vtkXYZMolReader2_SafeDownCast_09((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref maxValue, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkXYZMolReader = (vtkXYZMolReader2)Methods.CreateWrappedObject(mteStatus, maxValue, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkXYZMolReader.Register(null);
				}
			}
			return vtkXYZMolReader;
		}

		// Token: 0x06005A0C RID: 23052
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXYZMolReader2_SetFileName_10(HandleRef pThis, [MarshalAs(UnmanagedType.LPUTF8Str)] string arg);

		/// <summary>
		/// Get/Set the name of the XYZ Molecule file
		/// </summary>
		// Token: 0x06005A0D RID: 23053 RVA: 0x000824C7 File Offset: 0x000806C7
		public virtual void SetFileName(string arg)
		{
			vtkXYZMolReader2.vtkXYZMolReader2_SetFileName_10(base.GetCppThis(), arg);
		}

		// Token: 0x06005A0E RID: 23054
		[DllImport("Kitware.VTK.IOChemistry.Unmanaged.dll", CallingConvention = CallingConvention.Cdecl)]
		internal static extern void vtkXYZMolReader2_SetOutput_11(HandleRef pThis, HandleRef arg0);

		/// <summary>
		/// Get/Set the output (vtkMolecule) that the reader will fill
		/// </summary>
		// Token: 0x06005A0F RID: 23055 RVA: 0x000824D8 File Offset: 0x000806D8
		public override void SetOutput(vtkMolecule arg0)
		{
			vtkXYZMolReader2.vtkXYZMolReader2_SetOutput_11(base.GetCppThis(), (arg0 == null) ? default(HandleRef) : arg0.GetCppThis());
		}

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x0400086F RID: 2159
		public new const string MRFullTypeName = "Kitware.VTK.vtkXYZMolReader2";

		/// <summary>
		/// Automatically generated type registration mechanics.
		/// </summary>
		// Token: 0x04000870 RID: 2160
		public new static readonly string MRClassNameKey = "class vtkXYZMolReader2";
	}
}
