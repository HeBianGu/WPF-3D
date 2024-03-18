using Kitware.mummy.Runtime;
using System;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Kitware.VTK
{
	public class vtkEnSight6Reader : vtkEnSightReader
	{
		public new const string MRFullTypeName = "Kitware.VTK.vtkEnSight6Reader";

		public new static readonly string MRClassNameKey;

		static vtkEnSight6Reader()
		{
			vtkEnSight6Reader.MRClassNameKey = "class vtkEnSight6Reader";
			Methods.RegisterType(Assembly.GetExecutingAssembly(), vtkEnSight6Reader.MRClassNameKey, Type.GetType("Kitware.VTK.vtkEnSight6Reader"));
		}

		public vtkEnSight6Reader(IntPtr rawCppThis, bool callDisposalMethod, bool strong) : base(rawCppThis, callDisposalMethod, strong)
		{
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkEnSight6Reader_New(ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkEnSight6Reader New()
		{
			vtkEnSight6Reader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkEnSight6Reader.vtkEnSight6Reader_New(ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEnSight6Reader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		public vtkEnSight6Reader() : base(IntPtr.Zero, false, false)
		{
			uint num = 0u;
			uint num2 = 4294967295u;
			uint num3 = 0u;
			IntPtr rawCppThis = vtkEnSight6Reader.vtkEnSight6Reader_New(ref num, ref num2, ref num3);
			base.SetCppThis(rawCppThis, true, num != 0u && num3 >= 2u);
		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkEnSight6Reader_IsA_01(HandleRef pThis, string type);

		public override int IsA(string type)
		{
			return vtkEnSight6Reader.vtkEnSight6Reader_IsA_01(base.GetCppThis(), type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern int vtkEnSight6Reader_IsTypeOf_02(string type);

		public new static int IsTypeOf(string type)
		{
			return vtkEnSight6Reader.vtkEnSight6Reader_IsTypeOf_02(type);
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkEnSight6Reader_NewInstance_04(HandleRef pThis, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new vtkEnSight6Reader NewInstance()
		{
			vtkEnSight6Reader result = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkEnSight6Reader.vtkEnSight6Reader_NewInstance_04(base.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				result = (vtkEnSight6Reader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
			}
			return result;
		}

		[DllImport("Kitware.VTK.vtkIO.Unmanaged.dll")]
		internal static extern IntPtr vtkEnSight6Reader_SafeDownCast_05(HandleRef o, ref uint mteStatus, ref uint mteIndex, ref uint rawRefCount);

		public new static vtkEnSight6Reader SafeDownCast(vtkObjectBase o)
		{
			vtkEnSight6Reader vtkEnSight6Reader = null;
			uint mteStatus = 0u;
			uint mteIndex = 4294967295u;
			uint rawRefCount = 0u;
			IntPtr intPtr = vtkEnSight6Reader.vtkEnSight6Reader_SafeDownCast_05((o == null) ? default(HandleRef) : o.GetCppThis(), ref mteStatus, ref mteIndex, ref rawRefCount);
			if (IntPtr.Zero != intPtr)
			{
				bool flag;
				vtkEnSight6Reader = (vtkEnSight6Reader)Methods.CreateWrappedObject(mteStatus, mteIndex, rawRefCount, intPtr, true, out flag);
				if (flag)
				{
					vtkEnSight6Reader.Register(null);
				}
			}
			return vtkEnSight6Reader;
		}
	}
}
